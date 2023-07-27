private GameObject playerObject;
playerObject = GameObject.FindGameObjectWithTag("Player");
playerObject.GetComponent<U2PlayerController>().DecreaseLives();

// used in this instance to reference a method within a script attached to another object
// useful for when instantiating prefabs that need to reference external modules, as you cannot attach --
// objects in the scene to prefabs in your project view which have not been put into scene yet
// its not really recommended to use these Find methods at runtime, but I find they can be useful as a one off, especially if you use it in Start() methods


[SerializeField] private BoxCollider[] colliderObjects;
colliderObjects = FindObjectsOfType<BoxCollider>();
foreach (Collider colliders in colliderObjects) {
    Debug.Log(colliders);
}

// used to find all objects in the scene with a particular type - eg colliders, scripts, renderers
// used in this instance to find all objects with a box collider
// foreach statement goes through each box collider in the array - means they can all be manipulated individually


StartCoroutine(StartAnimation());
IEnumerator StartAnimation() {
    while (condition) {
        statements
        yield return null; }
}

// couroutines are used for functions which should run at the same time as other function
// for example an event that occurs over a long period of time, using a while loop would cause other functions to freeze until that while loop had finished  
// yield defines a place where the script will return to, allowing it to return to where it left off
