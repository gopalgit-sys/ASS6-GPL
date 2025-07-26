
const subjects = ['tamil', 'english', 'maths', 'science', 'socialScience'];

  function calculateResults() {
    let total = 0;

    for (const subject of subjects){
      const val = Number(document.getElementById(subject).value);
      if (isNaN(val) || val < 0 || val > 100) {
        alert(`Please enter valid marks between 0-100 for ${subject}`);
        return;
      }
      total += val;
    }

    const average = total / subjects.length;
    const grade = getGrade(average);

    document.getElementById('result').innerText =
      `Total: ${total}, Average: ${average.toFixed(1)}, Grade: ${grade}`;
  }

  function getGrade(average) {
    if (average >= 90) return 'A+';
    if (average >= 80) return 'A';
    if (average >= 70) return 'B';
    if (average >= 60) return 'C';
    if (average >= 50) return 'D';
    return 'F';
  }

  document.getElementById('calculateBtn').addEventListener('click', calculateResults);

  document.getElementById('clearBtn').addEventListener('click', () => {
    subjects.forEach(subject => document.getElementById(subject).value = '');
    document.getElementById('result').innerText = '';
  });