# codequiz
This test has two main parts. One with some small C# coding tasks, and one about Angular. Both parts uses code from this repository as a starting point. If you have trouble with cloning and pushing back to GitHub, it is OK if you just download the repo as a Zip and return your answers the same way. 

## C#: 
1. Download and install Visual Studio Community 2019 from here: https://visualstudio.microsoft.com/vs/. (If you for  some reason can't install Visual Studio, it is possible to use the dotnetcore command line interface.)
2. Clone the repository to your computer. 
3. Answer questions in files `Question1, Question2, Question4, Question4` under project `codequiz`
4. In questions 1-4 the results are just outputed to the console. It is better practice to use unit tests to test the results of our code. Create unit tests for the above questions that tests the implemented methods. A sample test is given in project `codequiz.tests`.

5. Commit your changes and push back to GitHub.

## Angular
This task uses the Angular tutorial as a starting point: https://angular.io/tutorial. The tutorial should contain all information you need to complete this task.

The source code from this tutorial is found int the folder `heroes` in the Git repository. (Also downloadable from: https://angular.io/generated/zips/toh-pt6/toh-pt6.zip)

Set up dev. environment and make sure it runs. Consult the tutorial if needed.

You will now add a feature to the Heroes app. 
Each hero will have a set of **skills**. A skill will be just a text string. 

(Hint add a new property  `skills: string[];` to the file `hero.ts`.)

On the `hero-detail.component` the list of skill should be shown. 
Hint:
```
<ul >
  <li *ngFor="let skill of hero.skills">
    {{skill}}
  </li>
</ul>
```

It should be possible to add skills for a hero. Add an `input` field and a `button` just below the list of skills. When clicking the button, the skill should show up in the list of skills.

Finally, Commit your changes and push back to GitHub.

