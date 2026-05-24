
def solve(target_sum, count, min_val, path):
    if count == 1:
        if target_sum >= min_val:
            print(path + [target_sum])
        return

    for i in range(min_val, target_sum + 1):
        solve(target_sum - i, count - 1, i, path + [i])

n = 11 # Число которое мы хотим разбить
for k in range(1, n + 1):
    solve(n, k, 1, [])