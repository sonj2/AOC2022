use std::fs;

fn main() {
    let data = fs::read_to_string("TestData.txt");
    let binding = data.unwrap();
    let lines = binding.lines();
    let mut vector = Vec::<i32>::new();
    for line in lines {
    }
}
