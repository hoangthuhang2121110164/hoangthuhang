import React, { Component } from 'react'
import imglogo from '../assets/images/logoo.jpg'
class Header extends Component {
    constructor(props) {
        super(props)
            }
            render() {
                return (
                    <header class="section-header">
                        <header class="section-header">
<section class="header-main border-bottom">
	<div class="container">
		<div class="row align-items-center">
			<div class="col-xl-2 col-lg-3 col-md-12">
				<a href="http://localhost:3000/" class="brand-wrap">
					<img class="logo" src={imglogo} style={{ width: "100%", height: "80%" }}/>
				</a> 
			</div>
			<div class="col-xl-6 col-lg-5 col-md-6">
				<form action="#" class="search-header">
					<div class="input-group w-100">
						<select class="custom-select border-right"  name="category_name">
								<option value="">All type</option><option value="codex">Special</option>
								<option value="comments">Only best</option>
								<option value="content">Latest</option>
						</select>
					    <input type="text" class="form-control" placeholder="Search"/>
					    
					    <div class="input-group-append">
					      <button class="btn bg-gray" type="submit">
					        <i class="fa fa-search"></i> Tìm Kiếm
					      </button>
					    </div>
				    </div>
				</form> 
			</div> 
			<div class="col-xl-4 col-lg-4 col-md-6">
				<div class="widgets-wrap float-md-right">
					<div class="widget-header mr-3">
						<a href="#" class="widget-view">
							<div class="icon-area">
								<i class="fa fa-user"></i>
								<span class="notify">3</span>
							</div>
							<small class="text"> Thông tin cá nhân </small>
						</a>
					</div>
					<div class="widget-header mr-3">
						<a href="#" class="widget-view">
							<div class="icon-area">
								<i class="fa fa-comment-dots"></i>
								<span class="notify">1</span>
							</div>
							<small class="text"> Tin Nhắn </small>
						</a>
					</div>
					<div class="widget-header mr-3">
						<a href="http://localhost:3000/orders" class="widget-view">
							<div class="icon-area">
								<i class="fa fa-store"></i>
							</div>
							<small class="text"> Đơn hàng </small>
						</a>
					</div>
					<div class="widget-header">
						<a href="http://localhost:3000/shoppingcart" class="widget-view">
							<div class="icon-area">
								<i class="fa fa-shopping-cart"></i>
							</div>
							<small class="text"> Giỏ hàng </small>
						</a>
					</div>
				</div> 
			</div>
		</div>
	</div> 
</section> 



<nav class="navbar navbar-main navbar-expand-lg border-bottom">
<div class="container">
	<button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#main_nav" aria-controls="main_nav" aria-expanded="false" aria-label="Toggle navigation">
	<span class="navbar-toggler-icon"></span>
	</button>

	<div class="collapse navbar-collapse" id="main_nav">
	<ul class="navbar-nav">
		<li class="nav-item dropdown">
			<a class="nav-link dropdown-toggle" data-toggle="dropdown" href="#"> <i class="fa fa-bars text-muted mr-2"></i> Danh Mục </a>
			<div class="dropdown-menu dropdown-large">
				<nav class="row">
					<div class="col-6">
						<a href="http://localhost:3000/">Home page 1</a>
						<a href="http://localhost:3000/detail">DETAIL</a>
						<a href="http://localhost:3000/category">All category</a>
						<a href="http://localhost:3000/content">CONTENT</a>
						<a href="http://localhost:3000/listing">LISTING</a>
						<a href="http://localhost:3000/offers">OFFERS</a>
						<a href="http://localhost:3000/orders">ORDER</a>
						<a href="http://localhost:3000/payment">PAYMENT</a>
						<a href="http://localhost:3000/seller">SELLER</a>
						<a href="http://localhost:3000/shoppingcart">SHOPPINGCARTr</a>
					</div>
					<div class="col-6">
						<a href="http://localhost:3000/userlogin">userlogin</a>
						<a href="http://localhost:3000/userregister">userregister</a>
						<a href="http://localhost:3000/wishlist">wishlistr</a>
						<a href="http://localhost:3000/">Profile wishlist</a>
						<a href="http://localhost:3000/">Profile setting</a>
						<a href="http://localhost:3000/">Profile address</a>
						<a href="http://localhost:3000/">RTL home page</a>
						<a href="http://localhost:3000/" target="_blank">More components</a>
					</div>
				</nav> 
			</div> 
		</li>
		<li class="nav-item">
			<a class="nav-link" href="http://localhost:3000/content">Giới Thiệu</a>
		</li>
		<li class="nav-item">
		<a class="nav-link" href="#">Bài Viết</a>
		</li>
		<li class="nav-item">
		<a class="nav-link" href="#">Liên Hệ</a>
		</li>
		<li class="nav-item">
		<a class="nav-link" href="http://localhost:3000/category">Category</a>
		</li>
		<li class="nav-item">
		<a class="nav-link" href="http://localhost:3000/seller">Thời trang nữ</a>
		</li>
		<li class="nav-item">
		<a class="nav-link" href="http://localhost:3000/seller">Thời trang nam</a>
		</li>
		{/* <li class="nav-item">
		<a class="nav-link" href="#">Sell with us</a>
		</li> */}
	</ul>
	<ul class="navbar-nav ml-md-auto">
			{/* <li class="nav-item">
			<a class="nav-link" href="#">Get the app</a>
		</li> */}
		<li class="nav-item dropdown">
			<a class="nav-link dropdown-toggle" href="http://example.com" data-toggle="dropdown">Ngôn Ngữ</a>
			<div class="dropdown-menu dropdown-menu-right">
			<a class="dropdown-item" href="#">Russian</a>
			<a class="dropdown-item" href="#">French</a>
			<a class="dropdown-item" href="#">Spanish</a>
			<a class="dropdown-item" href="#">Chinese</a>
			</div>
		</li>
		</ul>
	</div> 
</div> 
</nav>

</header>
                    </header>
                );
            }
    } export default Header