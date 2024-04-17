package com.example.andriod.network;

import com.example.andriod.dto.category.CategoryItemDTO;

import java.util.List;

import retrofit2.Call;
import retrofit2.http.GET;

public interface CategoriesApi {
    @GET("/api/CategoryControllers/CategoryGetAsync")
    public Call<List<CategoryItemDTO>> list();
}