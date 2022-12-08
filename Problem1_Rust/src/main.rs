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
    if sum != 0 {
        vector.push(sum);
    }
    let mut result = 0;
    vector.sort_by(|a, b| b.cmp(a));
    let mut index = 0;
    while index < 3usize {
        result += vector[index];
        index += 1;
    }
    println!("{}", result);
}