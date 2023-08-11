import React from 'react'
const Services = () => (
    <section class="padding-bottom">

<header class="section-heading">
	<h2 class="pb-2 text-center ">Tin Tức</h2>
</header>

<div class="row">
	<div class="col-md-3 col-sm-6">
		<article class="card card-post">
		  <img src={require("../../assets/images/tin1.jpg")} class="card-img-top"/>
		  <div class="card-body">
		    <h6 class="title">Show thời trang mới </h6>
		    <p class="small text-uppercase text-muted">Order protection</p>
		  </div>
		</article> 
	</div> 
	<div class="col-md-3 col-sm-6">
		<article class="card card-post">
		  <img src={require("../../assets/images/tin2.jpg")} class="card-img-top"/>
		  <div class="card-body">
		    <h6 class="title">Sale hàng thiết kế</h6>
		    <p class="small text-uppercase text-muted">Finance solution</p>
		  </div>
		</article> 
	</div> 
	<div class="col-md-3 col-sm-6">
		<article class="card card-post">
		  <img src={require("../../assets/images/tin3.jpg")} class="card-img-top"/>
		  <div class="card-body">
		    <h6 class="title">Sản phẩm hot nhất</h6>
		    <p class="small text-uppercase text-muted">Easy Inspection</p>
		  </div>
		</article> 
	</div> 
	<div class="col-md-3 col-sm-6">
		<article class="card card-post">
		  <img src={require("../../assets/images/tin4.jpg")} class="card-img-top"/>
		  <div class="card-body">
		    <h6 class="title">Thời trang mùa hè</h6>
		    <p class="small text-uppercase text-muted">Logistic services</p>
		  </div>
		</article> 
	</div> 
</div> 

</section>
)
export default Services