# Codility-Task-3
This is a test framework for the project SuperHeroes and SuperVillain. It covers both web automation testing using Selenium/SpecFlow/C# and API automation testing using Postman.
## Web Automation
To run the web automation you will simply have to open the **Codility Task 3.sln** file in [Visual Studio](https://visualstudio.microsoft.com/). You will also have to download some extensions to run the tests:

 - [SpecFlow](https://docs.specflow.org/projects/getting-started/en/latest/GettingStarted/Step1.html)
 - [NUnit 3 Test Adapter](https://marketplace.visualstudio.com/items?itemName=NUnitDevelopers.NUnit3TestAdapter)

Once you have installed the extensions and built the solution (therefore installing all the necessary nuget packages), you can run the tests from the **Test Explorer**.
This can be found here in Visual Studio:

![image](https://user-images.githubusercontent.com/49139851/180339152-3a439d57-4f7a-4a02-958e-d37a93f5b73e.png)

If you just want to run the full regression suite then you can just run the tag ***@UIRegression***

### Modifying variables (IMPORTANT)
Because some of the tests deal with user creation (and you cannot create a user twice), you may need to modify some variables for the tests to pass. For instance in the ***UserLogin.feature*** you will need to update the username to a unique string (within 1 to 10 characters) of your choice:

![image](https://user-images.githubusercontent.com/49139851/180346829-4eccb0c1-574d-4ddc-a0ca-45a8196e52be.png)

## API Automation
To run the API automation you will need to first download [Postman](https://www.postman.com/downloads/). Then you can import the Postman JSON files which are inside the ***Postman*** folder by choosing this option in the top left:

![image](https://user-images.githubusercontent.com/49139851/180354303-1c752a46-d369-49d4-a5ed-9c4a693a1a5f.png)

You will need to import both the environment (which includes all the necessary variables) and the collection (which include all the tests).
### Adjusting environment variables
Most likely by the time you run these tests, the API token will have expired and will need to be updated. To do that you can grab a new token at https://supervillain.herokuapp.com/api-docs/ from the auth/gentoken endpoint. Then you can pop it in the ***auth_key*** variable here:

![image](https://user-images.githubusercontent.com/49139851/180355330-f3952ad3-42e2-479a-8833-f75e06fcac00.png)

Also just like the web automation above, you will need a unique username which you can simply put into the ***Username*** environment variable, which will then persist through all the tests dynamically.
### Running the collection
To run the test suite you can just go to the collection and click the ***Run*** button on the top right:

![image](https://user-images.githubusercontent.com/49139851/180355711-097c9434-73ac-436e-8d4e-3a31a576fad7.png)

The tests are made to run in the exact order they're in for the collection. So if you want to play with each test by themsleves you may have to adjust the request body.

It's also important that you are running the collection under the correct environment. You can change the environment using this dropdown menu in the top right of the screen:

![image](https://user-images.githubusercontent.com/49139851/180356866-0eb78e2e-f307-43bb-8ebf-a5f1cba63ab2.png)

