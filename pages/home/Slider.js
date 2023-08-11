import React from 'react';
import '../../assets/js/bootstrap.bundle.min';
const Slider = () => (
    <section class="section-main padding-y">
        <main class="card">
            <div class="card-body">

                <div class="row">
                    <aside class="col-lg col-md-3 flex-lg-grow-0">
                        <nav class="nav-home-aside">
                            <h6 class="title-category">SẢN PHẨM <i class="d-md-none icon fa fa-chevron-down"></i></h6>
                            <ul class="menu-category">
                                <li><a href="#">Thời trang và quần áo</a></li>
                                <li><a href="#">Thời trang nam</a></li>
                                <li><a href="#">Thời trang nữ</a></li>
                                <li><a href="#">Thời trang mùa hè</a></li>
                                <li><a href="#">Thời trang mùa thu</a></li>
                                <li><a href="#">Thời trang mùa đông</a></li>
                                <li><a href="#">Mẫu thiết kế</a></li>
                                <li class="has-submenu"><a href="#">Các sản phẩm khác</a>
                                    <ul class="submenu">
                                        <li><a href="#">bikini</a></li>
                                        <li><a href="#">cosplay</a></li>
                                        <li><a href="#">hóa trang</a></li>
                                        <li><a href="#">đồ cho thuê</a></li>
                                    </ul>
                                </li>
                            </ul>
                        </nav>
                    </aside>
                    <div class="col-md-9 col-xl-7 col-lg-7">


                        <div id="carousel1_indicator" class="slider-home-banner carousel slide" data-ride="carousel">
                            <ol class="carousel-indicators">
                                <li data-target="#carousel1_indicator" data-slide-to="0" class="active"></li>
                                <li data-target="#carousel1_indicator" data-slide-to="1"></li>
                                <li data-target="#carousel1_indicator" data-slide-to="2"></li>
                            </ol>
                            <div class="carousel-inner">
                                <div class="carousel-item active">
                                    <img src={require("../../assets/images/nen3.jpg")} alt="First slide" />
                                </div>
                                <div class="carousel-item">
                                    <img src={require("../../assets/images/tin11.jpg")} alt="Second slide" />
                                </div>
                                <div class="carousel-item">
                                    <img src={require("../../assets/images/tin9.jpg")} alt="Third slide" />
                                </div>
                                
                                
                            </div>
                            <a class="carousel-control-prev" href="#carousel1_indicator" role="button" data-slide="prev">
                                <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                                <span class="sr-only">Trước</span>
                            </a>
                            <a class="carousel-control-next" href="#carousel1_indicator" role="button" data-slide="next">
                                <span class="carousel-control-next-icon" aria-hidden="true"></span>
                                <span class="sr-only">Next</span>
                            </a>
                        </div>

                    </div>
                    <div class="col-md d-none d-lg-block flex-grow-1">
                        <aside class="special-home-right">
                            <h6 class="bg-blue text-center text-white mb-0 p-2">TRANG PHỤC COSPLAY</h6>

                            <div class="card-banner border-bottom">
                                <div class="py-3" className="width:80%">
                                    <h6 class="card-title">cosplay loại 1 </h6>
                                    <a href="#" class="btn btn-secondary btn-sm"> Xem ngay  </a>
                                </div>
                           
                             <img src={require("../../assets/images/cp6.jpg")} height="80" class="img-bg" />
                             </div>
                            <div class="card-banner border-bottom">
                                <div class="py-3" className="width:80%">
                                    <h6 class="card-title">cosplay loại 2 </h6>
                                    <a href="#" class="btn btn-secondary btn-sm">  Xem ngay</a>
                                </div>
                                <img src={require("../../assets/images/cp3.jpg")} height="80" class="img-bg" />
                            </div>

                            <div class="card-banner border-bottom">
                                <div class="py-3" className="width:80%">
                                    <h6 class="card-title">cosplay loại 3 </h6>
                                    <a href="#" class="btn btn-secondary btn-sm"> Xem ngay </a>
                                </div>
                                <img src={require("../../assets/images/cp4.jpg")} height="80" class="img-bg" />
                            </div>
                        </aside>
                    </div>
                </div>
            </div>
        </main>
    </section>
);
export default Slider