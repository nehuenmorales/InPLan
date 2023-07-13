import { IntegerEditor, StringEditor, DateEditor, BooleanEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface ProyectosForm {
    IdEmpresa: IntegerEditor;
    IdArea: IntegerEditor;
    NombreProyecto: StringEditor;
    DescripcionProyecto: StringEditor;
    NroTicket: StringEditor;
    FechaCarga: DateEditor;
    FechaInicio: DateEditor;
    FechaFin: DateEditor;
    DocumentosRelacionados: StringEditor;
    Observaciones: StringEditor;
    Baja: BooleanEditor;
}

export class ProyectosForm extends PrefixedContext {
    static formKey = 'Parametros.Proyectos';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!ProyectosForm.init)  {
            ProyectosForm.init = true;

            var w0 = IntegerEditor;
            var w1 = StringEditor;
            var w2 = DateEditor;
            var w3 = BooleanEditor;

            initFormType(ProyectosForm, [
                'IdEmpresa', w0,
                'IdArea', w0,
                'NombreProyecto', w1,
                'DescripcionProyecto', w1,
                'NroTicket', w1,
                'FechaCarga', w2,
                'FechaInicio', w2,
                'FechaFin', w2,
                'DocumentosRelacionados', w1,
                'Observaciones', w1,
                'Baja', w3
            ]);
        }
    }
}