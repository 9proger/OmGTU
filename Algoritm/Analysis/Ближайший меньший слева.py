
def nearest_smaller_left(arr): #nearest_smaller_left - ближайший меньший слева

  stack = []
  result = []

  for i in range(len(arr)):

    while stack and arr[stack[-1]] >= arr[i]:

      stack.pop()

    result.append(stack[-1] if stack else -1)
    stack.append(i)

  return result

arr = [1, 4, 3, 6, 2]    # Наш массив
res = nearest_smaller_left(arr) # Массив индексов

print(f"Массив: {arr}")
print(f"Результат: {res}")

