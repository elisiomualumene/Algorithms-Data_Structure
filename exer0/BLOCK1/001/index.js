const output = document.querySelector("#main");

function isPrime(num) {
  if (num <= 1) return false;
  for (let i = 2; i <= Math.sqrt(num); i++) {
    if (num % i === 0) {
      return false;
    }
  }
  return true;
}

function main() {
  let primeCount = 0;
  let zeroCount = 0;
  let negativeSum = 0;
  let lastNegNumber = null;
  let negCounter = 0;

  while (true) {
    let input = parseInt(prompt("Digite um número:"));

    if (input < 0) {
      if (lastNegNumber === input) {
        negCounter++;
        if (negCounter === 3) {
          break;
        }
      } else {
        lastNegNumber = input;
        negCounter = 1;
      }
      negativeSum += input;
    } else if (input === 0) {
      zeroCount++;
    } else if (isPrime(input)) {
      primeCount++;
    }
  }

  output.innerHTML = `
    <h1>Quantidade de números primos: ${primeCount}</h1>
    <h1>Quintuplo da quantidade de números neutros: ${zeroCount}</h1>
    <h1>Soma dos números negativos: ${negativeSum}</h1>
    `;
}

main();
