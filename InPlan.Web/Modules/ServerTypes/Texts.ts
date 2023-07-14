import { proxyTexts } from "@serenity-is/corelib/q";

namespace InPlan.Texts {

    export declare namespace Db {

        namespace Administration {

            namespace Language {
                export const Id: string;
                export const LanguageId: string;
                export const LanguageName: string;
            }

            namespace Role {
                export const RoleId: string;
                export const RoleKey: string;
                export const RoleName: string;
            }

            namespace RolePermission {
                export const PermissionKey: string;
                export const RoleId: string;
                export const RoleName: string;
                export const RolePermissionId: string;
            }

            namespace User {
                export const DisplayName: string;
                export const Email: string;
                export const ImpersonationToken: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const IsActive: string;
                export const LastDirectoryUpdate: string;
                export const MobilePhoneNumber: string;
                export const MobilePhoneVerified: string;
                export const Password: string;
                export const PasswordConfirm: string;
                export const PasswordHash: string;
                export const PasswordSalt: string;
                export const Roles: string;
                export const Source: string;
                export const TwoFactorAuth: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
                export const UserId: string;
                export const UserImage: string;
                export const Username: string;
            }

            namespace UserPermission {
                export const Granted: string;
                export const PermissionKey: string;
                export const User: string;
                export const UserId: string;
                export const UserPermissionId: string;
                export const Username: string;
            }

            namespace UserRole {
                export const RoleId: string;
                export const User: string;
                export const UserId: string;
                export const UserRoleId: string;
                export const Username: string;
            }
        }

        namespace Implementacion {

            namespace DetalleImplementaciones {
                export const DescripcionTarea: string;
                export const DocumentosAdicionales: string;
                export const FechaFinalizacion: string;
                export const FechaInicio: string;
                export const IdDetalleImplementacion: string;
                export const IdEstadoTarea: string;
                export const IdEstadoTareaDescripcion: string;
                export const IdImplementacion: string;
                export const IdImplementacionNroTicket: string;
                export const IdTecnicoResponsable: string;
                export const IdTecnicoResponsableNombreCompleto: string;
                export const NotasAdicionales: string;
                export const Observaciones: string;
                export const Orden: string;
            }

            namespace DetalleImplementacionesRollBack {
                export const DescripcionTarea: string;
                export const DocumentosAdicionales: string;
                export const FechaFinalizacion: string;
                export const FechaInicio: string;
                export const IdDetalleImplementacionRollBack: string;
                export const IdEstadoTarea: string;
                export const IdEstadoTareaDescripcion: string;
                export const IdImplementacion: string;
                export const IdImplementacionNroTicket: string;
                export const IdTecnicoResponsable: string;
                export const IdTecnicoResponsableNombreCompleto: string;
                export const NotasAdicionales: string;
                export const Observaciones: string;
                export const Orden: string;
            }

            namespace EstadosDetalleImplementacioneRollBack {
                export const DocumentosAdicionales: string;
                export const FechaCarga: string;
                export const FechaEstado: string;
                export const IdDetalleImplementacionRollBack: string;
                export const IdDetalleImplementacionRollBackOrden: string;
                export const IdEstadoDetalleImplementacionRollBack: string;
                export const IdEstadoTarea: string;
                export const IdEstadoTareaDescripcion: string;
                export const IdTecnicoTarea: string;
                export const IdTecnicoTareaNombreCompleto: string;
                export const NotasAdicionales: string;
                export const Observaciones: string;
                export const UserId: string;
                export const Username: string;
            }

            namespace EstadosDetalleImplementaciones {
                export const DocumentosAdicionales: string;
                export const FechaCarga: string;
                export const FechaEstado: string;
                export const IdDetalleImplementacion: string;
                export const IdDetalleImplementacionOrden: string;
                export const IdEstadoDetalleImplementacion: string;
                export const IdEstadoTarea: string;
                export const IdEstadoTareaDescripcion: string;
                export const IdTecnicoTarea: string;
                export const IdTecnicoTareaNombreCompleto: string;
                export const NotasAdicionales: string;
                export const Observaciones: string;
                export const UserId: string;
                export const Username: string;
            }

            namespace Implementaciones {
                export const ConsideracionesPosteriores: string;
                export const ConsideracionesPrevias: string;
                export const Descripcion: string;
                export const DetallesList: string;
                export const DocumentosAdicionales: string;
                export const FechaImplementacion: string;
                export const FechaPlanificada: string;
                export const FechaSolicitud: string;
                export const IdAmbienteProyecto: string;
                export const IdAmbienteProyectoServidorDatos: string;
                export const IdImplementacion: string;
                export const IdProyecto: string;
                export const IdProyectoNombreProyecto: string;
                export const IdTecnicoImplementa: string;
                export const IdTecnicoImplementaNombreCompleto: string;
                export const IdTecnicoSolicitante: string;
                export const IdTecnicoSolicitanteNombreCompleto: string;
                export const IdTipoImplementacion: string;
                export const IdTipoImplementacionDescripcion: string;
                export const NotasAdicionales: string;
                export const NroTicket: string;
                export const Observaciones: string;
                export const UserId: string;
                export const Username: string;
            }

            namespace TiposImplementacion {
                export const Baja: string;
                export const Descripcion: string;
                export const IdArea: string;
                export const IdAreaDescripcion: string;
                export const IdEmpresa: string;
                export const IdEmpresaDescripcionCorta: string;
                export const IdTipoImplementacion: string;
                export const Observaciones: string;
            }
        }

        namespace Parametros {

            namespace Ambientes {
                export const Baja: string;
                export const Descripcion: string;
                export const IdAmbiente: string;
                export const IdArea: string;
                export const IdAreaDescripcion: string;
                export const IdEmpresa: string;
                export const IdEmpresaDescripcionCorta: string;
                export const Observaciones: string;
            }

            namespace AmbientesProyectos {
                export const DocumentosRelacionados: string;
                export const IdAmbiente: string;
                export const IdAmbienteDescripcion: string;
                export const IdAmbienteProyecto: string;
                export const IdProyecto: string;
                export const IdProyectoNombreProyecto: string;
                export const InstaciaServidor: string;
                export const NotasAdicionales: string;
                export const Observaciones: string;
                export const ServidorDatos: string;
                export const ServidorWeb: string;
            }

            namespace Clientes {
                export const Baja: string;
                export const Descripcion: string;
                export const DescripcionCorta: string;
                export const IdArea: string;
                export const IdAreaDescripcion: string;
                export const IdCliente: string;
                export const IdEmpresa: string;
                export const IdEmpresaDescripcionCorta: string;
                export const Observaciones: string;
            }

            namespace EstadosTareas {
                export const Baja: string;
                export const Descripcion: string;
                export const IdArea: string;
                export const IdAreaDescripcion: string;
                export const IdEmpresa: string;
                export const IdEmpresaDescripcionCorta: string;
                export const IdEstadoTarea: string;
                export const Observaciones: string;
            }

            namespace Proyectos {
                export const Baja: string;
                export const DescripcionProyecto: string;
                export const DocumentosRelacionados: string;
                export const FechaCarga: string;
                export const FechaFin: string;
                export const FechaInicio: string;
                export const IdArea: string;
                export const IdAreaDescripcion: string;
                export const IdEmpresa: string;
                export const IdEmpresaDescripcionCorta: string;
                export const IdProyecto: string;
                export const NombreProyecto: string;
                export const NroTicket: string;
                export const Observaciones: string;
            }

            namespace ProyectosTecnologias {
                export const IdProyecto: string;
                export const IdProyectoNombreProyecto: string;
                export const IdProyectoTecnologia: string;
                export const IdTecnologia: string;
                export const IdTecnologiaDescripcion: string;
            }

            namespace TecnicoProyectoTecnologias {
                export const IdTecnicoProyecto: string;
                export const IdTecnicoProyectoObservaciones: string;
                export const IdTecnicoProyectoTecnologia: string;
                export const IdTecnologia: string;
                export const IdTecnologiaDescripcion: string;
            }

            namespace Tecnicos {
                export const Baja: string;
                export const Celular: string;
                export const Email: string;
                export const IdArea: string;
                export const IdAreaDescripcion: string;
                export const IdEmpresa: string;
                export const IdEmpresaDescripcionCorta: string;
                export const IdTecnico: string;
                export const NombreCompleto: string;
                export const Observaciones: string;
            }

            namespace TecnicosProyectos {
                export const Baja: string;
                export const IdProyecto: string;
                export const IdProyectoNombreProyecto: string;
                export const IdTecnico: string;
                export const IdTecnicoProyecto: string;
                export const IdTecnicosNombreCompleto: string;
                export const Observaciones: string;
            }

            namespace Tecnologias {
                export const Baja: string;
                export const Descripcion: string;
                export const IdArea: string;
                export const IdAreaDescripcion: string;
                export const IdEmpresa: string;
                export const IdEmpresaDescripcionCorta: string;
                export const IdTecnologia: string;
                export const Observaciones: string;
            }
        }

        namespace Tenencia {

            namespace Areas {
                export const Baja: string;
                export const Descripcion: string;
                export const IdArea: string;
                export const IdEmpresa: string;
                export const IdEmpresaDescripcionCorta: string;
                export const Observaciones: string;
            }

            namespace Empresas {
                export const Baja: string;
                export const Descripcion: string;
                export const DescripcionCorta: string;
                export const IdEmpresa: string;
                export const Observaciones: string;
            }
        }
    }

    export declare namespace Forms {

        namespace Membership {

            namespace ChangePassword {
                export const FormTitle: string;
                export const SubmitButton: string;
                export const Success: string;
            }

            namespace ForgotPassword {
                export const FormInfo: string;
                export const FormTitle: string;
                export const SubmitButton: string;
                export const SuccessMessage: string;
            }

            namespace Login {
                export const ForgotPassword: string;
                export const LoginToYourAccount: string;
                export const OR: string;
                export const RememberMe: string;
                export const SignInButton: string;
                export const SignUpButton: string;
            }

            namespace ResetPassword {
                export const EmailSubject: string;
                export const FormTitle: string;
                export const SubmitButton: string;
                export const Success: string;
            }

            namespace SignUp {
                export const ActivateEmailSubject: string;
                export const ActivationCompleteMessage: string;
                export const ConfirmEmail: string;
                export const ConfirmPassword: string;
                export const DisplayName: string;
                export const Email: string;
                export const FormInfo: string;
                export const FormTitle: string;
                export const Password: string;
                export const SubmitButton: string;
                export const Success: string;
            }
        }
        export const SiteTitle: string;
    }

    export declare namespace Navigation {
        export const Dashboard: string;
        export const LogoutLink: string;
        export const SiteTitle: string;
    }

    export declare namespace Site {

        namespace AccessDenied {
            export const ClickToChangeUser: string;
            export const ClickToLogin: string;
            export const LackPermissions: string;
            export const NotLoggedIn: string;
            export const PageTitle: string;
        }

        namespace Layout {
            export const Language: string;
            export const Theme: string;
        }

        namespace RolePermissionDialog {
            export const DialogTitle: string;
            export const EditButton: string;
            export const SaveSuccess: string;
        }

        namespace UserDialog {
            export const EditPermissionsButton: string;
            export const EditRolesButton: string;
        }

        namespace UserPermissionDialog {
            export const DialogTitle: string;
            export const Grant: string;
            export const Permission: string;
            export const Revoke: string;
            export const SaveSuccess: string;
        }

        namespace ValidationError {
            export const Title: string;
        }
    }

    export declare namespace Validation {
        export const AuthenticationError: string;
        export const CurrentPasswordMismatch: string;
        export const DeleteForeignKeyError: string;
        export const EmailConfirm: string;
        export const EmailInUse: string;
        export const InvalidActivateToken: string;
        export const InvalidResetToken: string;
        export const MinRequiredPasswordLength: string;
        export const PasswordConfirmMismatch: string;
        export const SavePrimaryKeyError: string;
    }

    InPlan['Texts'] = proxyTexts(Texts, '', {Db:{Administration:{Language:{Id:1,LanguageId:1,LanguageName:1},Role:{RoleId:1,RoleKey:1,RoleName:1},RolePermission:{PermissionKey:1,RoleId:1,RoleName:1,RolePermissionId:1},User:{DisplayName:1,Email:1,ImpersonationToken:1,InsertDate:1,InsertUserId:1,IsActive:1,LastDirectoryUpdate:1,MobilePhoneNumber:1,MobilePhoneVerified:1,Password:1,PasswordConfirm:1,PasswordHash:1,PasswordSalt:1,Roles:1,Source:1,TwoFactorAuth:1,UpdateDate:1,UpdateUserId:1,UserId:1,UserImage:1,Username:1},UserPermission:{Granted:1,PermissionKey:1,User:1,UserId:1,UserPermissionId:1,Username:1},UserRole:{RoleId:1,User:1,UserId:1,UserRoleId:1,Username:1}},Implementacion:{DetalleImplementaciones:{DescripcionTarea:1,DocumentosAdicionales:1,FechaFinalizacion:1,FechaInicio:1,IdDetalleImplementacion:1,IdEstadoTarea:1,IdEstadoTareaDescripcion:1,IdImplementacion:1,IdImplementacionNroTicket:1,IdTecnicoResponsable:1,IdTecnicoResponsableNombreCompleto:1,NotasAdicionales:1,Observaciones:1,Orden:1},DetalleImplementacionesRollBack:{DescripcionTarea:1,DocumentosAdicionales:1,FechaFinalizacion:1,FechaInicio:1,IdDetalleImplementacionRollBack:1,IdEstadoTarea:1,IdEstadoTareaDescripcion:1,IdImplementacion:1,IdImplementacionNroTicket:1,IdTecnicoResponsable:1,IdTecnicoResponsableNombreCompleto:1,NotasAdicionales:1,Observaciones:1,Orden:1},EstadosDetalleImplementacioneRollBack:{DocumentosAdicionales:1,FechaCarga:1,FechaEstado:1,IdDetalleImplementacionRollBack:1,IdDetalleImplementacionRollBackOrden:1,IdEstadoDetalleImplementacionRollBack:1,IdEstadoTarea:1,IdEstadoTareaDescripcion:1,IdTecnicoTarea:1,IdTecnicoTareaNombreCompleto:1,NotasAdicionales:1,Observaciones:1,UserId:1,Username:1},EstadosDetalleImplementaciones:{DocumentosAdicionales:1,FechaCarga:1,FechaEstado:1,IdDetalleImplementacion:1,IdDetalleImplementacionOrden:1,IdEstadoDetalleImplementacion:1,IdEstadoTarea:1,IdEstadoTareaDescripcion:1,IdTecnicoTarea:1,IdTecnicoTareaNombreCompleto:1,NotasAdicionales:1,Observaciones:1,UserId:1,Username:1},Implementaciones:{ConsideracionesPosteriores:1,ConsideracionesPrevias:1,Descripcion:1,DetallesList:1,DocumentosAdicionales:1,FechaImplementacion:1,FechaPlanificada:1,FechaSolicitud:1,IdAmbienteProyecto:1,IdAmbienteProyectoServidorDatos:1,IdImplementacion:1,IdProyecto:1,IdProyectoNombreProyecto:1,IdTecnicoImplementa:1,IdTecnicoImplementaNombreCompleto:1,IdTecnicoSolicitante:1,IdTecnicoSolicitanteNombreCompleto:1,IdTipoImplementacion:1,IdTipoImplementacionDescripcion:1,NotasAdicionales:1,NroTicket:1,Observaciones:1,UserId:1,Username:1},TiposImplementacion:{Baja:1,Descripcion:1,IdArea:1,IdAreaDescripcion:1,IdEmpresa:1,IdEmpresaDescripcionCorta:1,IdTipoImplementacion:1,Observaciones:1}},Parametros:{Ambientes:{Baja:1,Descripcion:1,IdAmbiente:1,IdArea:1,IdAreaDescripcion:1,IdEmpresa:1,IdEmpresaDescripcionCorta:1,Observaciones:1},AmbientesProyectos:{DocumentosRelacionados:1,IdAmbiente:1,IdAmbienteDescripcion:1,IdAmbienteProyecto:1,IdProyecto:1,IdProyectoNombreProyecto:1,InstaciaServidor:1,NotasAdicionales:1,Observaciones:1,ServidorDatos:1,ServidorWeb:1},Clientes:{Baja:1,Descripcion:1,DescripcionCorta:1,IdArea:1,IdAreaDescripcion:1,IdCliente:1,IdEmpresa:1,IdEmpresaDescripcionCorta:1,Observaciones:1},EstadosTareas:{Baja:1,Descripcion:1,IdArea:1,IdAreaDescripcion:1,IdEmpresa:1,IdEmpresaDescripcionCorta:1,IdEstadoTarea:1,Observaciones:1},Proyectos:{Baja:1,DescripcionProyecto:1,DocumentosRelacionados:1,FechaCarga:1,FechaFin:1,FechaInicio:1,IdArea:1,IdAreaDescripcion:1,IdEmpresa:1,IdEmpresaDescripcionCorta:1,IdProyecto:1,NombreProyecto:1,NroTicket:1,Observaciones:1},ProyectosTecnologias:{IdProyecto:1,IdProyectoNombreProyecto:1,IdProyectoTecnologia:1,IdTecnologia:1,IdTecnologiaDescripcion:1},TecnicoProyectoTecnologias:{IdTecnicoProyecto:1,IdTecnicoProyectoObservaciones:1,IdTecnicoProyectoTecnologia:1,IdTecnologia:1,IdTecnologiaDescripcion:1},Tecnicos:{Baja:1,Celular:1,Email:1,IdArea:1,IdAreaDescripcion:1,IdEmpresa:1,IdEmpresaDescripcionCorta:1,IdTecnico:1,NombreCompleto:1,Observaciones:1},TecnicosProyectos:{Baja:1,IdProyecto:1,IdProyectoNombreProyecto:1,IdTecnico:1,IdTecnicoProyecto:1,IdTecnicosNombreCompleto:1,Observaciones:1},Tecnologias:{Baja:1,Descripcion:1,IdArea:1,IdAreaDescripcion:1,IdEmpresa:1,IdEmpresaDescripcionCorta:1,IdTecnologia:1,Observaciones:1}},Tenencia:{Areas:{Baja:1,Descripcion:1,IdArea:1,IdEmpresa:1,IdEmpresaDescripcionCorta:1,Observaciones:1},Empresas:{Baja:1,Descripcion:1,DescripcionCorta:1,IdEmpresa:1,Observaciones:1}}},Forms:{Membership:{ChangePassword:{FormTitle:1,SubmitButton:1,Success:1},ForgotPassword:{FormInfo:1,FormTitle:1,SubmitButton:1,SuccessMessage:1},Login:{ForgotPassword:1,LoginToYourAccount:1,OR:1,RememberMe:1,SignInButton:1,SignUpButton:1},ResetPassword:{EmailSubject:1,FormTitle:1,SubmitButton:1,Success:1},SignUp:{ActivateEmailSubject:1,ActivationCompleteMessage:1,ConfirmEmail:1,ConfirmPassword:1,DisplayName:1,Email:1,FormInfo:1,FormTitle:1,Password:1,SubmitButton:1,Success:1}},SiteTitle:1},Navigation:{Dashboard:1,LogoutLink:1,SiteTitle:1},Site:{AccessDenied:{ClickToChangeUser:1,ClickToLogin:1,LackPermissions:1,NotLoggedIn:1,PageTitle:1},Layout:{Language:1,Theme:1},RolePermissionDialog:{DialogTitle:1,EditButton:1,SaveSuccess:1},UserDialog:{EditPermissionsButton:1,EditRolesButton:1},UserPermissionDialog:{DialogTitle:1,Grant:1,Permission:1,Revoke:1,SaveSuccess:1},ValidationError:{Title:1}},Validation:{AuthenticationError:1,CurrentPasswordMismatch:1,DeleteForeignKeyError:1,EmailConfirm:1,EmailInUse:1,InvalidActivateToken:1,InvalidResetToken:1,MinRequiredPasswordLength:1,PasswordConfirmMismatch:1,SavePrimaryKeyError:1}}) as any;
}

export const Texts = InPlan.Texts;