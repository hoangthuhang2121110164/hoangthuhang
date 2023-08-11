import React from "react";

const Deal = () => (
    <section class="padding-bottom">
        <div class="card card-deal">
         <div class="col-heading content-body">             
            <div class="row no-gutters items-wrap">
            <header class="pb-2 text-center ">
          <h2 class="pb-2 text-center ">     
              SALE tháng 8</h2>   
          </header>
          <div class="row no-gutters items-wrap"></div>
          <div class="timer">
              <div> <span class="num">04</span> <small>Days</small></div>
              <div> <span class="num">12</span> <small>Hours</small></div>
              <div> <span class="num">58</span> <small>Min</small></div>
              <div> <span class="num">02</span> <small>Sec</small></div>
          </div>
                <div class="col-md col-6">
                    <figure class="card-product-grid card-sm">
                        <a href="detail-product/1" class="img-wrap">
                        <img src={require("../../assets/images/aoyjun11.jpg")} style={{ width: "100%", height: "145%", objectFit: "cover" }} />

                        </a>
                        <div class="text-wrap p-3">
                            <a href="#" class="title">Áo kiểu 1</a>
                            <span class="badge badge-danger"> -20% </span>
                        </div>
                    </figure>
                </div> 
                <div class="col-md col-6">
                    <figure class="card-product-grid card-sm">
                        <a href="#" class="img-wrap">
                        <img src={require("../../assets/images/kieu1.jpg")} style={{ width: "100%", height: "145%", objectFit: "cover" }} />

                        </a>
                        <div class="text-wrap p-3">
                            <a href="#" class="title">Áo kiểu 2</a>
                            <span class="badge badge-danger"> -5% </span>
                        </div>
                    </figure>
                </div>
                <div class="col-md col-6">
                    <figure class="card-product-grid card-sm">
                        <a href="#" class="img-wrap">
                        <img src={require("../../assets/images/kieu4.jpg")} style={{ width: "90%", height: "100%", objectFit: "cover" }} />

                        </a>
                        <div class="text-wrap p-3">
                            <a href="#" class="title">Áo kiểu 1</a>
                            <span class="badge badge-danger"> -20% </span>
                        </div>
                    </figure>
                </div> 
                <div class="col-md col-6">
                    <figure class="card-product-grid card-sm">
                        <a href="#" class="img-wrap">
                        <img src={require("../../assets/images/thun1.jpg")} style={{ width: "100%", height: "110%", objectFit: "cover" }} />

                        </a>
                        <div class="text-wrap p-3">
<a href="#" class="title">Thun đen 1</a>
                            <span class="badge badge-danger"> -15% </span>
                        </div>
                    </figure>
                </div> 
                <div class="col-md col-6">
                    <figure class="card-product-grid card-sm">
                        <a href="#" class="img-wrap">
                        <img src={require("../../assets/images/thun2.jpg")} style={{ width: "100%", height: "110%", objectFit: "cover" }} />

                        </a>
                        <div class="text-wrap p-3">
                            <a href="#" class="title text-truncate">Thun đen 2</a>
                            <span class="badge badge-danger"> -10% </span>
                        </div>
                    </figure>
                </div> 
            </div>
        </div>
</div>
    </section>
);
export default Deal;