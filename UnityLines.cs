private GameObject playerObject;
playerObject = GameObject.FindGameObjectWithTag("Player");
playerObject.GetComponent<U2PlayerController>().DecreaseLives();

// used in this instance to reference a method within a script attached to another object
// useful for when instantiating prefabs that need to reference external modules, as you cannot attach --
// objects in the scene to prefabs in your project view which have not been put into scene yet
// its not really recommended to use these Find methods at runtime, but I find they can be useful as a one off, especially if you use it in Start() methods