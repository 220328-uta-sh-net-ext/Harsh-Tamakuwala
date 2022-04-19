#! /bin/bash
echo
echo "Lets play fizzbuzz game!!";
echo "--------------------------";
echo 
echo "enter number less than 0 to exit from the game..."
echo

checkNum=0;
while (( $checkNum >= 0 ));
do
    read -p "Please enter any number between 0 to 20 : " checkNum;
    if (( $checkNum < 20 ))
    then
        for((i=1;i<=$checkNum;i++))
        do
            if (($i % 3 == 0)) && (($i % 5 == 0))
            then 
                echo "fizzbuzz";
                echo
            elif (($i % 3 == 0))
            then    
                echo "fizz";
                echo
            elif (($i % 5 == 0))
            then  
                echo "buzz";
                echo
            else
                echo $i;
                echo
            fi
            sleep 1;
        done     
    else 
        echo "Not in range"
    fi          
done