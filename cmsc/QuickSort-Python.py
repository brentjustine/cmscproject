def quick_sort(array):
    if len(array) <= 1:
        return array
    pivot = array[len(array) // 2]
    left = [x for x in array if x < pivot]
    middle = [x for x in array if x == pivot]
    right = [x for x in array if x > pivot]
    return quick_sort(left) + middle + quick_sort(right)

array = [12, 4, 5, 6, 7, 3, 1, 15, 10, 9, 8, 2, 11, 14, 13]
sorted_array = quick_sort(array)
print("Sorted array:")
print(sorted_array)
