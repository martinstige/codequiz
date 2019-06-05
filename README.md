# codequiz
## C#: 
1. Download and install Visual Studio Community 2019 from here: https://visualstudio.microsoft.com/vs/
2. Clone the repository to your computer
3. Answer questions in files `Question1, Question2, Question4, Question4` under project `codequiz`
4. In questions 1-4 the results are just outputed to the console. It is better practice to use unit tests to test the results of our code. Create unit tests for the above questions that tests the implemented methods. A sample test is given in project `codequiz.tests`.

5. Commit your changes and push back to GitHub.

## Angular
This task uses the Angular tutorial as a starting point: https://angular.io/tutorial
1. Download the source code of the finished app from this tutorial: https://angular.io/generated/zips/toh-pt6/toh-pt6.zip
2. Set up dev. environment and make sure it runs.
3. You will now add a feature to the Heroes app. 
Each hero will have a set of skills. A skill will be just a text string. (Hint add a new property  `skills: string[];` to the file `hero.ts`.)

On the `hero-detail.component` the list of skill should be shown. 
Hint:
```
<ul >
  <li *ngFor="let skill of hero.skills">
    {{skill}}
  </li>
</ul>
```

It should be possible to add skills for a hero. Add an `input` field and a `button` just below the list of skills. 
4. Commit your changes and push back to GitHub.

