//This solves only Part 1

use std::fs;

fn main() {
    let data = fs::read_to_string("TestData.txt");
    let binding = data.unwrap();
    let lines = binding.lines();
    let mut sum = 0;
    let mut vector = Vec::<i32>::new();
    for line in lines {
        if line == "" {
            vector.push(sum);
            sum = 0;
        } else {
            let num = line.parse::<i32>().unwrap();
            sum += num;
        }
    }
    let mut max = 0;
    for i in vector {
        if i > max {
            max = i;
        }
    }
    println!("{}", max);
}