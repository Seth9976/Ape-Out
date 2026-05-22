using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000195 RID: 405
	public sealed class XmlSchemaCompilationSettings : Object
	{
		// Token: 0x06002169 RID: 8553 RVA: 0x0009CEFC File Offset: 0x0009B0FC
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaCompilationSettings()
		{
			Il2CppClassPointerStore<XmlSchemaCompilationSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaCompilationSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaCompilationSettings>.NativeClassPtr);
			XmlSchemaCompilationSettings.NativeFieldInfoPtr_enableUpaCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaCompilationSettings>.NativeClassPtr, "enableUpaCheck");
			XmlSchemaCompilationSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaCompilationSettings>.NativeClassPtr, 100668061);
			XmlSchemaCompilationSettings.NativeMethodInfoPtr_get_EnableUpaCheck_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaCompilationSettings>.NativeClassPtr, 100668062);
		}

		// Token: 0x0600216A RID: 8554 RVA: 0x0009CF68 File Offset: 0x0009B168
		[CallerCount(0)]
		public unsafe XmlSchemaCompilationSettings()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaCompilationSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaCompilationSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000BA1 RID: 2977
		// (get) Token: 0x0600216B RID: 8555 RVA: 0x0009CFA4 File Offset: 0x0009B1A4
		public unsafe bool EnableUpaCheck
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaCompilationSettings.NativeMethodInfoPtr_get_EnableUpaCheck_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600216C RID: 8556 RVA: 0x0000E867 File Offset: 0x0000CA67
		public XmlSchemaCompilationSettings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BA0 RID: 2976
		// (get) Token: 0x0600216D RID: 8557 RVA: 0x0009CFE0 File Offset: 0x0009B1E0
		// (set) Token: 0x0600216E RID: 8558 RVA: 0x0000E870 File Offset: 0x0000CA70
		public unsafe bool enableUpaCheck
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaCompilationSettings.NativeFieldInfoPtr_enableUpaCheck);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaCompilationSettings.NativeFieldInfoPtr_enableUpaCheck)) = value;
			}
		}

		// Token: 0x040018C6 RID: 6342
		private static readonly IntPtr NativeFieldInfoPtr_enableUpaCheck;

		// Token: 0x040018C7 RID: 6343
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040018C8 RID: 6344
		private static readonly IntPtr NativeMethodInfoPtr_get_EnableUpaCheck_Public_get_Boolean_0;
	}
}
