<h1>Example01</h1>
<p>Design an algorithm and flowchart that finds and shows the larger of two numbers given different from each other.</p>

```
1. START
2. WRITE ("Please enter the first number :")
3. READ firstNumber
4. WRITE ("Please enter the second number :")
5. READ secondNumber
6. IF firstNumber > secondNumber THEN WRITE firstNumber
7. ELSE WRITE secondNumber
8. END
```
![Example02 Flowchart](/image/example01.png "Example02 Flowchart")

<h1>Example02</h1>
<p>Design the algorithm and flowchart that finds out whether the student has passed the course according to the midterm and final grades.</p>

```
1. START
2. WRITE ("Please enter your midterm grade :")
3. READ midterm
4. WRITE ("Please enter your final grade :")
5. READ final
6. CALCULATE Average(midterm,final)
7.          average = (midterm * 0.4) + (final * 0.7)
8.          RETURN average
9. COURSE STATUS  CourseStatus(average)
10.                IF average >= 60 THEN WRITE "You passed the course."
11.                ELSE WRITE "You failed the course."
12. END                  
```
![Example01 Flowchart](/image/example02.png "Example01 Flowchart")

<h1>Example03</h1>
<p>Design the algorithm and flowchart to find whether the given integer is zero, positive, or negative.</p>

```
1. START
2. WRITE ("Please enter a number :")
3. READ number
4. IF number == 0 WRITE "The number you entered is equal to zero"
5. ELSE IF number < 0 WRITE "The number you entered is a negative number."
6. ELSE IF number > 0 WRITE "The number you entered is a positive number"
7. END
```

![Example03 Flowchart](/image/example03_01.png "Example03 Flowchart")

<h1>Example04</h1>
<p>Make the algorithm that writes the programmer's name on the screen 10 times.</p>

```
1. START
2. WRITE ("Please enter a name :")
3. READ name
4. RETURN name ReturName(strign name)
5.               int i = 0
6.               WRITE name
8.               i++;
9.               if i < 10 GO TO STEP 5
10. END
```

![Example04 Flowchart](/image/example04.png "Example04 Flowchart")


