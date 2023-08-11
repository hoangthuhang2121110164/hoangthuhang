import React from 'react';

const ListingFilter = () => (
  

        <div class="card mb-3">
            <div class="card-body">
                <div class="row">
                    <div class="col-md-2"> Bạn đang ở đây: </div> 
                    <nav class="col-md-8"> 
                        <ol class="breadcrumb">
                            <li class="breadcrumb-item"><a href="#">Trang chủ</a></li>
                            <li class="breadcrumb-item"><a href="#">Tên danh mục</a></li>
                            <li class="breadcrumb-item"><a href="#">Danh mục phụ</a></li>
                            <li class="breadcrumb-item active" aria-current="page">Mặt hàng</li>
                        </ol>  
                    </nav> 
                </div>
          
                <div class="row">
                    <div class="col-md-2">Lọc theo</div> 
                    <div class="col-md-10"> 
                        <ul class="list-inline">
                            <li class="list-inline-item mr-3 dropdown">
                                <a href="#" class="dropdown-toggle" data-toggle="dropdown">Loại nhà cung cấp</a>
                                <div class="dropdown-menu p-3" style={{maxwidth:"400px"}}>	
                                    <label class="form-check">
                                        <input type="radio" name="myfilter" class="form-check-input"/> Nhà cung cấp tốt
                                    </label>
                                    <label class="form-check">	
                                        <input type="radio" name="myfilter" class="form-check-input"/> Nhà cung cấp tốt nhất
                                    </label>
                                    <label class="form-check">
                                        <input type="radio" name="myfilter" class="form-check-input"/> Nhà cung cấp mới
                                    </label>
                                </div> 
                            </li>
                            <li class="list-inline-item mr-3 dropdown">
                                <a href="#" class="dropdown-toggle" data-toggle="dropdown">Quốc gia</a>
                                <div class="dropdown-menu p-3">	
                                    <label class="form-check"> <input type="checkbox" class="form-check-input"/> Trung Quốc </label>
                                    <label class="form-check"> <input type="checkbox" class="form-check-input"/> Nhật Bản </label>
                                    <label class="form-check"> <input type="checkbox" class="form-check-input"/> Uzbekistan </label>
                                    <label class="form-check"> <input type="checkbox" class="form-check-input"/> Nga </label>
                                </div> 
                            </li>
                            <li class="list-inline-item mr-3 dropdown">
                                <a href="#" class="dropdown-toggle" data-toggle="dropdown">Tính năng</a>
                                <div class="dropdown-menu">
                                    <a href="" class="dropdown-item">Kháng khuẩn</a>
                                    <a href="" class="dropdown-item">Có nút</a>
                                    <a href="" class="dropdown-item">An toàn hơn</a>
                                </div>
                            </li>
                            <li class="list-inline-item mr-3"><a href="#">Màu sắc</a></li>
                            <li class="list-inline-item mr-3"><a href="#">Kích thước</a></li>
                            <li class="list-inline-item mr-3">
                                <div class="form-inline">
                                    <label class="mr-2">Giá</label>
                                    <input class="form-control form-control-sm" placeholder="Tối thiểu" type="number"/>
                                    <span class="px-2"> - </span>
                                    <input class="form-control form-control-sm" placeholder="Tối đa" type="number"/>
                                    <button type="submit" class="btn btn-sm btn-light ml-2">Đồng ý</button>
                                </div>
                            </li>
                            <li class="list-inline-item mr-3">
                                <label class="custom-control mt-1 custom-checkbox">
                                    <input type="checkbox" class="custom-control-input"/>
                                    <div class="custom-control-label">Sẵn sàng giao hàng</div>
                                </label>
                            </li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>

);

export default ListingFilter;