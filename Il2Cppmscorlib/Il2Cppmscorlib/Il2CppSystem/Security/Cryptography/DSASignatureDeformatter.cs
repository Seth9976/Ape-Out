using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x020002E6 RID: 742
	public class DSASignatureDeformatter : AsymmetricSignatureDeformatter
	{
		// Token: 0x060031CF RID: 12751 RVA: 0x000F9DD0 File Offset: 0x000F7FD0
		// Note: this type is marked as 'beforefieldinit'.
		static DSASignatureDeformatter()
		{
			Il2CppClassPointerStore<DSASignatureDeformatter>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "DSASignatureDeformatter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DSASignatureDeformatter>.NativeClassPtr);
			DSASignatureDeformatter.NativeFieldInfoPtr__oid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DSASignatureDeformatter>.NativeClassPtr, "_oid");
			DSASignatureDeformatter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DSASignatureDeformatter>.NativeClassPtr, 100671174);
		}

		// Token: 0x060031D0 RID: 12752 RVA: 0x000F9E28 File Offset: 0x000F8028
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209938, XrefRangeEnd = 209944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DSASignatureDeformatter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DSASignatureDeformatter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DSASignatureDeformatter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031D1 RID: 12753 RVA: 0x0001172B File Offset: 0x0000F92B
		public DSASignatureDeformatter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BEA RID: 3050
		// (get) Token: 0x060031D2 RID: 12754 RVA: 0x000F9E64 File Offset: 0x000F8064
		// (set) Token: 0x060031D3 RID: 12755 RVA: 0x00011734 File Offset: 0x0000F934
		public unsafe string _oid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSASignatureDeformatter.NativeFieldInfoPtr__oid);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSASignatureDeformatter.NativeFieldInfoPtr__oid), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04002AC5 RID: 10949
		private static readonly IntPtr NativeFieldInfoPtr__oid;

		// Token: 0x04002AC6 RID: 10950
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
