import { StringEditor, TextAreaEditor, BooleanEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface EmpresasForm {
    DescripcionCorta: StringEditor;
    Descripcion: StringEditor;
    Observaciones: TextAreaEditor;
    Baja: BooleanEditor;
}

export class EmpresasForm extends PrefixedContext {
    static formKey = 'Tenencia.Empresas';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!EmpresasForm.init)  {
            EmpresasForm.init = true;

            var w0 = StringEditor;
            var w1 = TextAreaEditor;
            var w2 = BooleanEditor;

            initFormType(EmpresasForm, [
                'DescripcionCorta', w0,
                'Descripcion', w0,
                'Observaciones', w1,
                'Baja', w2
            ]);
        }
    }
}