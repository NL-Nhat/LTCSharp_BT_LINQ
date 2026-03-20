Nguyễn Long Nhật - 23115053122126
BT_LINQ

PHẦN 1 – LINQ CƠ BẢN (1–7)

Bài 1. Lọc số chẵn
Cho danh sách:

List<int> numbers = new List<int>{1,2,3,4,5,6,7,8};
Yêu cầu:

Dùng LINQ để lấy các số chẵn.

Bài 2. Lọc số lớn hơn 5
Từ danh sách numbers, dùng LINQ để lấy các số > 5.

Bài 3. Sắp xếp tăng dần
Từ danh sách số nguyên:

Sắp xếp tăng dần bằng LINQ.

Bài 4. Sắp xếp giảm dần
Sắp xếp danh sách giảm dần bằng:

OrderByDescending
Bài 5. Bình phương các số
Tạo danh sách mới chứa bình phương của mỗi số.

Ví dụ:

1 2 3 → 1 4 9
Bài 6. Đếm số chẵn
Dùng LINQ để đếm số phần tử chẵn.

Bài 7. Kiểm tra có số lớn hơn 10 không
Sử dụng:

Any()
PHẦN 2 – LINQ VỚI OBJECT (8–14)
Cho class:

class Student {     public int Id {get; set;}     public string Name {get; set;}     public double Score {get; set;} }
Danh sách:

List<Student> students = new List<Student>() {     new Student{Id=1, Name="An", Score=8},     new Student{Id=2, Name="Binh", Score=6},     new Student{Id=3, Name="Chi", Score=9},     new Student{Id=4, Name="Dung", Score=7} };
Bài 8. Lọc sinh viên điểm >= 8
Dùng LINQ để lấy sinh viên giỏi.

Bài 9. Lấy danh sách tên sinh viên
Kết quả chỉ gồm:

An Binh Chi Dung
Gợi ý:

Select()
Bài 10. Sắp xếp theo điểm
Sắp xếp sinh viên theo điểm giảm dần.

Bài 11. Lấy sinh viên điểm cao nhất
Dùng LINQ để tìm sinh viên có Score cao nhất.

Bài 12. Đếm số sinh viên đạt
Đếm sinh viên có:

Score >= 7
Bài 13. Lấy sinh viên đầu tiên có điểm > 7
Dùng:

FirstOrDefault()
Bài 14. Kiểm tra có sinh viên rớt không
Sinh viên rớt nếu:

Score < 5
PHẦN 3 – LINQ NÂNG CAO (15–20)
Bài 15. Loại bỏ phần tử trùng
Cho danh sách:

1 2 2 3 4 4 5
Dùng LINQ để loại bỏ số trùng.

Gợi ý:

Distinct()
Bài 16. Tính tổng
Dùng LINQ để tính:

Sum()
Bài 17. Tính trung bình
Tính điểm trung bình sinh viên.

Average()
Bài 18. Nhóm sinh viên theo xếp loại
Phân nhóm:

>=8	Giỏi
>=6	Khá
<6	Trung bình
Gợi ý:

GroupBy()
Bài 19. Tìm số xuất hiện nhiều nhất
Cho danh sách số nguyên, tìm giá trị xuất hiện nhiều nhất.

Bài 20. Top 3 sinh viên điểm cao nhất
Dùng LINQ để:

Sắp xếp theo điểm

Lấy 3 sinh viên đầu

Gợi ý:

Take(3)

BÀI TẬP TRÊN LỚP
<img width="845" height="302" alt="image" src="https://github.com/user-attachments/assets/bff5844e-09f3-41ba-9608-3c6e4469f2a1" />
