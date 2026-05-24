
from collections import deque

def sliding_window_minimum_deque(arr, k):  # Поиск минимума в окне размером K
    if not arr or k <= 0:
        return []

    dq = deque()
    result = []

    for i in range(len(arr)):

        if dq and dq[0] < i - k + 1:
            dq.popleft()

        while dq and arr[dq[-1]] >= arr[i]:
            dq.pop()
        dq.append(i)

        if i >= k - 1:
            result.append(arr[dq[0]])

    return result

A = [2, 3, 4, 1, 3, 4, 5] # Массив
K = 3 # Окно
print(f"Массив: {A}, K: {K}")
print(f"Минимумы: {sliding_window_minimum_deque(A, K)}")