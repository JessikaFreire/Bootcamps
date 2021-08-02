package com.dio.projeto.controller.form;

import com.dio.projeto.model.JornadaTrabalho;
import lombok.Getter;
import lombok.Setter;

import javax.validation.constraints.NotEmpty;
import javax.validation.constraints.NotNull;

@Getter
@Setter
public class JornadaTrabalhoForm {
    @NotNull @NotEmpty
    private String descricao;

}
