//8_1
function removeEveryOther($array) {
    $result = array();

    for ($i = 0; $i < count($array); $i += 2) {
        $result[] = $array[$i]; 
    }

    return $result; 
}
//8_2
function enough($cap, $on, $wait) {
  $availableSpace = $cap - $on;
  
  if ($availableSpace >= $wait) {
    return 0; 
  } else {

    return $wait - $availableSpace;
  }
}
//8_3
function square_sum($numbers) {
  $sum = 0;
  
  foreach ($numbers as $num) {
    $sum += $num * $num;
  }
  
  return $sum;
}
//7_1
function multiples($m, $n) {
  $result = [];
  
  for ($i = 1; $i <= $m; $i++) {

    $result[] = $i * $n;
  }
  
  return $result;
}
//7_2
function disemvowel($string) {
  $vowels = '/[aeiouAEIOU]/';
  
  return preg_replace($vowels, '', $string);
}
//7_3
function square_digits($num): int {

$numStr = (string)$num;
$result = '';

for ($i = 0; $i < strlen($numStr); $i++) {
  $result .= (string)(($numStr[$i]) ** 2);
}

return (int)$result;
}
//6_1
function expanded_form(int $n): string {
  $numStr = (string)$n;
  $length = strlen($numStr);  
  $result = [];  
  
  for ($i = 0; $i < $length; $i++) {
    $digit = $numStr[$i];
    
    if ($digit != '0') {
      $expanded = $digit * pow(10, $length - $i - 1);
      $result[] = $expanded;
    }
  }
  
  return implode(' + ', $result);
}

