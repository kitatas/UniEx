using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using Assert = UnityEngine.Assertions.Assert;

namespace UniEx.Tests
{
    public sealed class GameObjectTest
    {
        [Test]
        public void Component()
        {
            // Get Or Add (get)
            {
                GameObject self = new GameObject();
                int hash1 = self.GetOrAddComponent<Transform>().GetHashCode();
                int hash2 = self.GetComponent<Transform>().GetHashCode();
                Assert.AreEqual(hash1, hash2);
            }

            // Get Or Add (add)
            {
                GameObject self = new GameObject();
                int hash1 = self.GetOrAddComponent<Rigidbody>().GetHashCode();
                int hash2 = self.GetComponent<Rigidbody>().GetHashCode();
                Assert.AreEqual(hash1, hash2);
            }

            // Has
            {
                GameObject self = new GameObject();
                Assert.IsFalse(self.HasComponent<Rigidbody>());

                self.AddComponent<Rigidbody>();
                Assert.IsTrue(self.HasComponent<Rigidbody>());
            }
        }

        [Test]
        public void Set()
        {
            // Tag
            {
                GameObject self = new GameObject { tag = "Untagged" };
                self.SetTag("Player");
                Assert.AreEqual(self.tag, "Player");
            }

            // Layer
            {
                GameObject self = new GameObject { layer = LayerMask.NameToLayer("Default") };
                self.SetLayer("Ignore Raycast");
                Assert.AreEqual(self.layer, LayerMask.NameToLayer("Ignore Raycast"));
            }

            // Child
            {
                GameObject self = new GameObject();
                Assert.AreEqual(self.transform.childCount, 0);

                GameObject child = new GameObject();
                self.SetChild(child);
                Assert.AreEqual(self.transform.childCount, 1);
            }

            // Children (array)
            {
                GameObject self = new GameObject();
                Assert.AreEqual(self.transform.childCount, 0);

                GameObject[] children = new GameObject[] { new GameObject(), new GameObject(), new GameObject() };
                self.SetChildren(children);
                Assert.AreEqual(self.transform.childCount, children.Length);
            }

            // Children (list)
            {
                GameObject self = new GameObject();
                Assert.AreEqual(self.transform.childCount, 0);

                List<GameObject> children = new List<GameObject> { new GameObject(), new GameObject(), new GameObject() };
                self.SetChildren(children);
                Assert.AreEqual(self.transform.childCount, children.Count);
            }
        }

        [Test]
        public void All()
        {
            // SetActive (array)
            {
                GameObject[] self = new GameObject[] { new GameObject(), new GameObject(), new GameObject() };
                self.SetActiveAll(false);
                foreach (var gameObject in self) Assert.IsFalse(gameObject.activeSelf);

                self.SetActiveAll(true);
                foreach (var gameObject in self) Assert.IsTrue(gameObject.activeSelf);
            }

            // SetActive (list)
            {
                List<GameObject> self = new List<GameObject> { new GameObject(), new GameObject(), new GameObject() };
                self.SetActiveAll(false);
                foreach (var gameObject in self) Assert.IsFalse(gameObject.activeSelf);

                self.SetActiveAll(true);
                foreach (var gameObject in self) Assert.IsTrue(gameObject.activeSelf);
            }
        }

        [Test]
        public void Children()
        {
            // Each
            {
                GameObject self = new GameObject();
                GameObject child1 = new GameObject { name = "child" };
                child1.transform.SetParent(self.transform);
                GameObject child2 = new GameObject { name = "child" };
                child2.transform.SetParent(self.transform);
                GameObject child3 = new GameObject { name = "child" };
                child3.transform.SetParent(self.transform);
                foreach (Transform child in self.transform) Assert.AreEqual(child.name, "child");

                self.EachChildren(x => x.name = "no name");
                foreach (Transform child in self.transform) Assert.AreEqual(child.name, "no name");
            }

            // SetActive
            {
                GameObject self = new GameObject();
                GameObject child1 = new GameObject();
                child1.transform.SetParent(self.transform);
                GameObject child2 = new GameObject();
                child2.transform.SetParent(self.transform);
                GameObject child3 = new GameObject();
                child3.transform.SetParent(self.transform);

                self.SetActiveChildren(false);
                foreach (Transform child in self.transform) Assert.IsFalse(child.gameObject.activeSelf);

                self.SetActiveChildren(true);
                foreach (Transform child in self.transform) Assert.IsTrue(child.gameObject.activeSelf);
            }
        }

        [UnityTest]
        public IEnumerator DestroyCoroutine()
        {
            // Remove Component
            {
                GameObject self = new GameObject { name = "obj" };
                self.AddComponent<Rigidbody>();
                Assert.IsTrue(self.TryGetComponent<Rigidbody>(out var rigidbody));

                Assert.IsTrue(self.RemoveComponent<Rigidbody>());
                yield return null;
                Assert.IsFalse(self.RemoveComponent<Rigidbody>());
            }

            // Destroy All (array)
            {
                GameObject[] self = new GameObject[] { new GameObject(), new GameObject(), new GameObject() };
                foreach (var gameObject in self) Assert.IsNotNull(gameObject);

                self.DestroyAll();
                yield return null;
                foreach (var gameObject in self) Assert.IsNull(gameObject);
            }

            // Destroy All (list)
            {
                List<GameObject> self = new List<GameObject> { new GameObject(), new GameObject(), new GameObject() };
                foreach (var gameObject in self) Assert.IsNotNull(gameObject);

                self.DestroyAll();
                yield return null;
                foreach (var gameObject in self) Assert.IsNull(gameObject);
            }

            // Destroy Children
            {
                GameObject self = new GameObject();
                GameObject child1 = new GameObject();
                child1.transform.SetParent(self.transform);
                GameObject child2 = new GameObject();
                child2.transform.SetParent(self.transform);
                GameObject child3 = new GameObject();
                child3.transform.SetParent(self.transform);
                foreach (Transform child in self.transform) Assert.IsNotNull(child.gameObject);

                self.DestroyChildren();
                yield return null;
                foreach (Transform child in self.transform) Assert.IsNull(child.gameObject);
            }
        }
    }
}