# Hồ Quang Đông_3303_StudentManager

## 1. Mô tả dự án (Project Description)
Đây là dự án phần mềm **Quản lý Sinh viên (Student Manager)** được phát triển nhằm mục đích thực hành quy trình quản lý mã nguồn chuyên nghiệp với Git và GitHub.

Dự án bao gồm các chức năng cơ bản:
- Quản lý thông tin sinh viên (Model Student).
- Giao diện người dùng (UI) để tương tác.
- Các chức năng Thêm, Sửa, Xóa sinh viên.
- Chức năng Tìm kiếm sinh viên.
- Kiểm tra tính hợp lệ của dữ liệu (Validation).

## 2. Hướng dẫn cài đặt và chạy 
Để chạy dự án này trên máy cục bộ, hãy làm theo các bước sau:

1.  **Clone repository về máy:**
    git clone https://github.com/rumvn84/HOQUANGDONG_3303_StudentManager.git
    hoặc có thể mở VS chọn Clone a reposiotry và dán link trên vào và mở .
    ```
2.  **Mở dự án:**
    - Khởi động Visual Studio.
    - Chọn `Open Project/Solution` và tìm đến file `.sln` trong thư mục vừa clone.
3.  **Chạy ứng dụng:**
    - Nhấn nút `Start` hoặc `F5` trong Visual Studio để build và chạy chương trình.

## 3. Danh sách 5 Commit chính
1.  **Commit 1:** `Initial commit: StudentManager project` (Khởi tạo dự án)
2.  **Commit 2:** `UI: add main form layout and controls` (Thiết kế giao diện)
3.  **Commit 3:** `Model: add Student class` (Tạo lớp đối tượng sinh viên)
4.  **Commit 4:** `Feature: implement add/update/delete` (Hoàn thiện chức năng thêm/sửa/xóa)
5.  **Commit 5:** `Feature: add search function` (Thêm chức năng tìm kiếm)

## 4. Pull Request (PR)
Chức năng mới (Validation) đã được phát triển trên nhánh `feature/intro` và merge vào `main` thông qua Pull Request:

- **Link PR:** https://github.com/rumvn84/HOQUANGDONG_3303_StudentManager/pull/1
- **Trạng thái:** Đã Merge .

## 5. Ảnh UI
Giao diện ứng dụng (UI) : QuanLySinhVien(GIT)\UI.png

## 6. Log hoặc link log
* (HEAD -> main, origin/main, origin/HEAD) Merge pull request #1 from feature/intro
|\
| * (origin/feature/intro) Validation: prevent empty student name
|/
* Feature: add search function
* Feature: implement add/update/delete
* Model: add Student class
* UI: add main form layout and controls
* Initial commit: StudentManager project