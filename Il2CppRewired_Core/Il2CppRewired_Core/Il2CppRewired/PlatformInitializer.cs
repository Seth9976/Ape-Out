using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppRewired.Data;
using Il2CppRewired.Interfaces;
using Il2CppSystem;

namespace Il2CppRewired
{
	// Token: 0x0200001F RID: 31
	public class PlatformInitializer : Object
	{
		// Token: 0x06000275 RID: 629 RVA: 0x00036CB4 File Offset: 0x00034EB4
		// Note: this type is marked as 'beforefieldinit'.
		static PlatformInitializer()
		{
			Il2CppClassPointerStore<PlatformInitializer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired", "PlatformInitializer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlatformInitializer>.NativeClassPtr);
			PlatformInitializer.NativeMethodInfoPtr_Initialize_Public_Abstract_Virtual_New_Object_IConfigVars_Internal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInitializer>.NativeClassPtr, 100663675);
			PlatformInitializer.NativeMethodInfoPtr_CreateTool_Public_Abstract_Virtual_New_IElementIdentifierTool_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInitializer>.NativeClassPtr, 100663676);
			PlatformInitializer.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformInitializer>.NativeClassPtr, 100663677);
		}

		// Token: 0x06000276 RID: 630 RVA: 0x00036D20 File Offset: 0x00034F20
		[CallerCount(0)]
		public unsafe virtual Object Initialize(IConfigVars_Internal configVars)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(configVars);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlatformInitializer.NativeMethodInfoPtr_Initialize_Public_Abstract_Virtual_New_Object_IConfigVars_Internal_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06000277 RID: 631 RVA: 0x00036D7C File Offset: 0x00034F7C
		[CallerCount(0)]
		public unsafe virtual IElementIdentifierTool CreateTool(string inputSourceString)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(inputSourceString);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlatformInitializer.NativeMethodInfoPtr_CreateTool_Public_Abstract_Virtual_New_IElementIdentifierTool_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IElementIdentifierTool>(intPtr3) : null;
			}
		}

		// Token: 0x06000278 RID: 632 RVA: 0x00036DD8 File Offset: 0x00034FD8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlatformInitializer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlatformInitializer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformInitializer.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000279 RID: 633 RVA: 0x00002CF9 File Offset: 0x00000EF9
		public PlatformInitializer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000228 RID: 552
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Abstract_Virtual_New_Object_IConfigVars_Internal_0;

		// Token: 0x04000229 RID: 553
		private static readonly IntPtr NativeMethodInfoPtr_CreateTool_Public_Abstract_Virtual_New_IElementIdentifierTool_String_0;

		// Token: 0x0400022A RID: 554
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
