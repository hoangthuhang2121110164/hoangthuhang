import React, { Component } from "react";
import { Link } from "react-router-dom";
class Footer extends Component {
  constructor(props) {
    super(props);
  }
  render() {
    return (
      <footer class="Footerclass">
        <footer class="Footerclass">
          <div class="container">
            <section class="footer-top padding-y-lg text-white">
              <div class="row">
                <aside class="col-md col-6">
                  <h6 class="title">Thương Hiệu</h6>
                  <ul class="list-unstyled">
                    <li>
                      {" "}
                      <a href="#">Adidas</a>
                    </li>
                    <li>
                      {" "}
                      <a href="#">Puma</a>
                    </li>
                    <li>
                      {" "}
                      <a href="#">Reebok</a>
                    </li>
                    <li>
                      {" "}
                      <a href="#">Nike</a>
                    </li>
                  </ul>
                </aside>
                <aside class="col-md col-6">
                  <h6 class="title">Công ty</h6>
                  <ul class="list-unstyled">
                    <li>
                      {" "}
                      <a href="#">Về chúng tôi</a>
                    </li>
                    <li>
                      {" "}
                      <a href="#">Sự nghiệp</a>
                    </li>
                    <li>
                      {" "}
                      <a href="#">Tim môt cửa hang</a>
                    </li>
                    <li>
                      {" "}
                      <a href="#">Quy tắc và điều khoản</a>
                    </li>
                    <li>
                      {" "}
                      <a href="#">Sơ đồ trang web</a>
                    </li>
                  </ul>
                </aside>
                <aside class="col-md col-6">
                  <h6 class="title">Trợ giúp</h6>
                  <ul class="list-unstyled">
                    <li>
                      {" "}
                      <a href="#">Liên hệ chúng tôi</a>
                    </li>
                    <li>
                      {" "}
                      <a href="#">Hoàn tiền</a>
                    </li>
                    <li>
                      {" "}
                      <a href="#">Tình trạng đặt hàng</a>
                    </li>
                    <li>
                      {" "}
                      <a href="#">thông tin vận chuyển</a>
                    </li>
                    <li>
                      {" "}
                      <a href="#">mở tranh chấp</a>
                    </li>
                  </ul>
                </aside>
                <aside class="col-md col-6">
                  <h6 class="title">Tài khoản</h6>
                  <ul class="list-unstyled">
                    <li>
                      {" "}
                      <a href="#"> Đăng nhập người dùng </a>
                    </li>
                    <li>
                      {" "}
                      <a href="#"> đăng ký người dùng </a>
                    </li>
                    <li>
                      {" "}
                      <a href="#"> Thiết lập tài khoản</a>
                    </li>
                    <li>
                      {" "}
                      <a href="#"> đơn đặt hàng của tôi </a>
                    </li>
                  </ul>
                </aside>
                <aside class="col-md">
                  <h6 class="title">Xã hội</h6>
                  <ul class="list-unstyled">
                    <li>
                      <a href="#">
                        {" "}
                        <i class="fab fa-facebook"></i> Facebook{" "}
                      </a>
                    </li>
                    <li>
                      <a href="#">
                        {" "}
                        <i class="fab fa-twitter"></i> Twitter{" "}
                      </a>
                    </li>
                    <li>
                      <a href="#">
                        {" "}
                        <i class="fab fa-instagram"></i> Instagram{" "}
                      </a>
                    </li>
                    <li>
                      <a href="#">
                        {" "}
                        <i class="fab fa-youtube"></i> Youtube{" "}
                      </a>
                    </li>
                  </ul>
                </aside>
              </div>
            </section>

            <section class="footer-bottom text-center">
              <p class="text-white">
                Chính sách bảo mật - Điều khoản sử dụng - Thông tin người dùng
                Hướng dẫn yêu cầu pháp lý
              </p>
              <p class="text-muted">
                &copy 2019 Tên công ty, Bảo lưu mọi quyền{" "}
              </p>
            </section>
          </div>
        </footer>
      </footer>
    );
  }
}
export default Footer;
