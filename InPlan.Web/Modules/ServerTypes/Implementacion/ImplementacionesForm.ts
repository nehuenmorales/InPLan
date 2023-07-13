import { IntegerEditor, StringEditor, DateEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface ImplementacionesForm {
    IdProyecto: IntegerEditor;
    IdAmbienteProyecto: IntegerEditor;
    IdTecnicoSolicitante: IntegerEditor;
    IdTecnicoImplementa: IntegerEditor;
    IdTipoImplementacion: IntegerEditor;
    NroTicket: StringEditor;
    FechaSolicitud: DateEditor;
    FechaPlanificada: DateEditor;
    FechaImplementacion: DateEditor;
    ConsideracionesPrevias: StringEditor;
    Descripcion: StringEditor;
    ConsideracionesPosteriores: StringEditor;
    NotasAdicionales: StringEditor;
    DocumentosAdicionales: StringEditor;
    Observaciones: StringEditor;
    UserId: IntegerEditor;
}

export class ImplementacionesForm extends PrefixedContext {
    static formKey = 'Implementacion.Implementaciones';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!ImplementacionesForm.init)  {
            ImplementacionesForm.init = true;

            var w0 = IntegerEditor;
            var w1 = StringEditor;
            var w2 = DateEditor;

            initFormType(ImplementacionesForm, [
                'IdProyecto', w0,
                'IdAmbienteProyecto', w0,
                'IdTecnicoSolicitante', w0,
                'IdTecnicoImplementa', w0,
                'IdTipoImplementacion', w0,
                'NroTicket', w1,
                'FechaSolicitud', w2,
                'FechaPlanificada', w2,
                'FechaImplementacion', w2,
                'ConsideracionesPrevias', w1,
                'Descripcion', w1,
                'ConsideracionesPosteriores', w1,
                'NotasAdicionales', w1,
                'DocumentosAdicionales', w1,
                'Observaciones', w1,
                'UserId', w0
            ]);
        }
    }
}