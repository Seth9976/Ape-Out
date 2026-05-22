using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppRewired.Data;
using Il2CppRewired.Interfaces;
using Il2CppSystem;

namespace Il2CppRewired.InputManagers
{
	// Token: 0x02000009 RID: 9
	public class Initializer : PlatformInitializer
	{
		// Token: 0x06000057 RID: 87 RVA: 0x0000BC68 File Offset: 0x00009E68
		// Note: this type is marked as 'beforefieldinit'.
		static Initializer()
		{
			Il2CppClassPointerStore<Initializer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Windows.dll", "Rewired.InputManagers", "Initializer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Initializer>.NativeClassPtr);
			Initializer.NativeFieldInfoPtr_eDAXhdMRZhWnltLqkXsJgCDlfaMa = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Initializer>.NativeClassPtr, "eDAXhdMRZhWnltLqkXsJgCDlfaMa");
			Initializer.NativeMethodInfoPtr_GetPlatformInitializer_Public_Static_PlatformInitializer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Initializer>.NativeClassPtr, 100663360);
			Initializer.NativeMethodInfoPtr_Initialize_Public_Virtual_Object_IConfigVars_Internal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Initializer>.NativeClassPtr, 100663361);
			Initializer.NativeMethodInfoPtr_CreateTool_Public_Virtual_IElementIdentifierTool_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Initializer>.NativeClassPtr, 100663362);
			Initializer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Initializer>.NativeClassPtr, 100663363);
		}

		// Token: 0x06000058 RID: 88 RVA: 0x0000BCFC File Offset: 0x00009EFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PlatformInitializer GetPlatformInitializer()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Initializer.NativeMethodInfoPtr_GetPlatformInitializer_Public_Static_PlatformInitializer_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlatformInitializer>(intPtr3) : null;
		}

		// Token: 0x06000059 RID: 89 RVA: 0x0000BD30 File Offset: 0x00009F30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 348143, XrefRangeEnd = 348158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object Initialize(IConfigVars_Internal configVars)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(configVars);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Initializer.NativeMethodInfoPtr_Initialize_Public_Virtual_Object_IConfigVars_Internal_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600005A RID: 90 RVA: 0x0000BD8C File Offset: 0x00009F8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 348158, XrefRangeEnd = 348164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IElementIdentifierTool CreateTool(string inputSourceString)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(inputSourceString);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Initializer.NativeMethodInfoPtr_CreateTool_Public_Virtual_IElementIdentifierTool_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IElementIdentifierTool>(intPtr3) : null;
			}
		}

		// Token: 0x0600005B RID: 91 RVA: 0x0000BDE8 File Offset: 0x00009FE8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Initializer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Initializer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Initializer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600005C RID: 92 RVA: 0x000022A4 File Offset: 0x000004A4
		public Initializer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600005D RID: 93 RVA: 0x0000BE24 File Offset: 0x0000A024
		// (set) Token: 0x0600005E RID: 94 RVA: 0x000022AD File Offset: 0x000004AD
		public unsafe static PlatformInitializer eDAXhdMRZhWnltLqkXsJgCDlfaMa
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Initializer.NativeFieldInfoPtr_eDAXhdMRZhWnltLqkXsJgCDlfaMa, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformInitializer>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Initializer.NativeFieldInfoPtr_eDAXhdMRZhWnltLqkXsJgCDlfaMa, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000045 RID: 69
		private static readonly IntPtr NativeFieldInfoPtr_eDAXhdMRZhWnltLqkXsJgCDlfaMa;

		// Token: 0x04000046 RID: 70
		private static readonly IntPtr NativeMethodInfoPtr_GetPlatformInitializer_Public_Static_PlatformInitializer_0;

		// Token: 0x04000047 RID: 71
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Object_IConfigVars_Internal_0;

		// Token: 0x04000048 RID: 72
		private static readonly IntPtr NativeMethodInfoPtr_CreateTool_Public_Virtual_IElementIdentifierTool_String_0;

		// Token: 0x04000049 RID: 73
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
