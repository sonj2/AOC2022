use std::fs;

fn main() {
    let data = fs::read_to_string("input.txt");
    let binding = data.unwrap();
    let lines = binding.lines();
    let mut roundscore = 0;
    let mut finalscore = 0;
    for line in lines {
        
    }
    println!("Final score: {}", finalscore);
}
