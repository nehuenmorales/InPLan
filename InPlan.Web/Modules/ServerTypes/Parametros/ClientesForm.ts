import { LookupEditor, StringEditor, TextAreaEditor, BooleanEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface ClientesForm {
    IdEmpresa: LookupEditor;
    IdArea: LookupEditor;
    DescripcionCorta: StringEditor;
    Descripcion: StringEditor;
    Observaciones: TextAreaEditor;
    Baja: BooleanEditor;
}

export class ClientesForm extends PrefixedContext {
    static formKey = 'Parametros.Clientes';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!ClientesForm.init)  {
            ClientesForm.init = true;

            var w0 = LookupEditor;
            var w1 = StringEditor;
            var w2 = TextAreaEditor;
            var w3 = BooleanEditor;

            initFormType(ClientesForm, [
                'IdEmpresa', w0,
                'IdArea', w0,
                'DescripcionCorta', w1,
                'Descripcion', w1,
                'Observaciones', w2,
                'Baja', w3
            ]);
        }
    }
}