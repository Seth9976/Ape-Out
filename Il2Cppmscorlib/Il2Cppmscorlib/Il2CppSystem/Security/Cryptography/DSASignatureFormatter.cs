using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x020002E7 RID: 743
	public class DSASignatureFormatter : AsymmetricSignatureFormatter
	{
		// Token: 0x060031D4 RID: 12756 RVA: 0x000F9E8C File Offset: 0x000F808C
		// Note: this type is marked as 'beforefieldinit'.
		static DSASignatureFormatter()
		{
			Il2CppClassPointerStore<DSASignatureFormatter>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "DSASignatureFormatter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DSASignatureFormatter>.NativeClassPtr);
			DSASignatureFormatter.NativeFieldInfoPtr__oid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DSASignatureFormatter>.NativeClassPtr, "_oid");
			DSASignatureFormatter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DSASignatureFormatter>.NativeClassPtr, 100671175);
		}

		// Token: 0x060031D5 RID: 12757 RVA: 0x000F9EE4 File Offset: 0x000F80E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209944, XrefRangeEnd = 209950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DSASignatureFormatter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DSASignatureFormatter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DSASignatureFormatter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031D6 RID: 12758 RVA: 0x00011753 File Offset: 0x0000F953
		public DSASignatureFormatter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BEB RID: 3051
		// (get) Token: 0x060031D7 RID: 12759 RVA: 0x000F9F20 File Offset: 0x000F8120
		// (set) Token: 0x060031D8 RID: 12760 RVA: 0x0001175C File Offset: 0x0000F95C
		public unsafe string _oid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSASignatureFormatter.NativeFieldInfoPtr__oid);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSASignatureFormatter.NativeFieldInfoPtr__oid), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04002AC7 RID: 10951
		private static readonly IntPtr NativeFieldInfoPtr__oid;

		// Token: 0x04002AC8 RID: 10952
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
