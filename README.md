<h1>Example01</h1>
<p>Design an algorithm and flowchart that finds and shows the larger of two numbers given different from each other.</p>

```
START
WRITE ("Please enter the first number :")
READ firstNumber
WRITE ("Please enter the second number :")
READ secondNumber
IF firstNumber > secondNumber THEN WRITE firstNumber
ELSE WRITE secondNumber
END
```
![Example02 Flowchart](/image/example01.png "Example02 Flowchart")

<h1>Example02</h1>
<p>Design the algorithm and flowchart that finds out whether the student has passed the course according to the midterm and final grades.</p>

```
START
WRITE ("Please enter your midterm grade :")
READ midterm
WRITE ("Please enter your final grade :")
READ final
CALCULATE Average(midterm,final)
            average = (midterm * 0.4) + (final * 0.7)
            RETURN average
COURSE STATUS  CourseStatus(average)
                  IF average >= 60 THEN WRITE "You passed the course."
                  ELSE WRITE "You failed the course."
END                  
```
![Example01 Flowchart](/image/example02.png "Example01 Flowchart")

<h1>Example03</h1>
<p>Design the algorithm and flowchart to find whether the given integer is zero, positive, or negative.</p>

```
START
WRITE ("Please enter a number :")
READ number
IF number == 0 WRITE "The number you entered is equal to zero"
ELSE IF number < 0 WRITE "The number you entered is a negative number."
ELSE IF number > 0 WRITE "The number you entered is a positive number"
BİTİR
```

![Example03 Flowchart](/image/example04.png "Example03 Flowchart")


