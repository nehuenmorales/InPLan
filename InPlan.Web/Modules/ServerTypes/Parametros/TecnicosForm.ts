import { LookupEditor, StringEditor, TextAreaEditor, BooleanEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface TecnicosForm {
    IdEmpresa: LookupEditor;
    IdArea: LookupEditor;
    NombreCompleto: StringEditor;
    Celular: StringEditor;
    Email: StringEditor;
    Observaciones: TextAreaEditor;
    Baja: BooleanEditor;
}

export class TecnicosForm extends PrefixedContext {
    static formKey = 'Parametros.Tecnicos';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!TecnicosForm.init)  {
            TecnicosForm.init = true;

            var w0 = LookupEditor;
            var w1 = StringEditor;
            var w2 = TextAreaEditor;
            var w3 = BooleanEditor;

            initFormType(TecnicosForm, [
                'IdEmpresa', w0,
                'IdArea', w0,
                'NombreCompleto', w1,
                'Celular', w1,
                'Email', w1,
                'Observaciones', w2,
                'Baja', w3
            ]);
        }
    }
}