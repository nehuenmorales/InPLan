import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { TecnicoProyectoTecnologiasColumns, TecnicoProyectoTecnologiasRow, TecnicoProyectoTecnologiasService } from '../../ServerTypes/Parametros';
import { TecnicoProyectoTecnologiasDialog } from './TecnicoProyectoTecnologiasDialog';

@Decorators.registerClass('InPlan.Parametros.TecnicoProyectoTecnologiasGrid')
export class TecnicoProyectoTecnologiasGrid extends EntityGrid<TecnicoProyectoTecnologiasRow, any> {
    protected getColumnsKey() { return TecnicoProyectoTecnologiasColumns.columnsKey; }
    protected getDialogType() { return TecnicoProyectoTecnologiasDialog; }
    protected getRowDefinition() { return TecnicoProyectoTecnologiasRow; }
    protected getService() { return TecnicoProyectoTecnologiasService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}