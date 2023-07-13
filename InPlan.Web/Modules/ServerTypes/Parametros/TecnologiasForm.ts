import { IntegerEditor, StringEditor, BooleanEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface TecnologiasForm {
    IdEmpresa: IntegerEditor;
    IdArea: IntegerEditor;
    Descripcion: StringEditor;
    Observaciones: StringEditor;
    Baja: BooleanEditor;
}

export class TecnologiasForm extends PrefixedContext {
    static formKey = 'Parametros.Tecnologias';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!TecnologiasForm.init)  {
            TecnologiasForm.init = true;

            var w0 = IntegerEditor;
            var w1 = StringEditor;
            var w2 = BooleanEditor;

            initFormType(TecnologiasForm, [
                'IdEmpresa', w0,
                'IdArea', w0,
                'Descripcion', w1,
                'Observaciones', w1,
                'Baja', w2
            ]);
        }
    }
}