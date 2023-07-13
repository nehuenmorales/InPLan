import { IntegerEditor, StringEditor, BooleanEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface ClientesForm {
    IdEmpresa: IntegerEditor;
    IdArea: IntegerEditor;
    DescripcionCorta: StringEditor;
    Descripcion: StringEditor;
    Observaciones: StringEditor;
    Baja: BooleanEditor;
}

export class ClientesForm extends PrefixedContext {
    static formKey = 'Parametros.Clientes';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!ClientesForm.init)  {
            ClientesForm.init = true;

            var w0 = IntegerEditor;
            var w1 = StringEditor;
            var w2 = BooleanEditor;

            initFormType(ClientesForm, [
                'IdEmpresa', w0,
                'IdArea', w0,
                'DescripcionCorta', w1,
                'Descripcion', w1,
                'Observaciones', w1,
                'Baja', w2
            ]);
        }
    }
}