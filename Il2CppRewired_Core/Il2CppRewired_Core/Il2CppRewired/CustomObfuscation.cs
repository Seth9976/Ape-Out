using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppRewired
{
	// Token: 0x0200010C RID: 268
	public sealed class CustomObfuscation : Attribute
	{
		// Token: 0x06001A1D RID: 6685 RVA: 0x00092C64 File Offset: 0x00090E64
		// Note: this type is marked as 'beforefieldinit'.
		static CustomObfuscation()
		{
			Il2CppClassPointerStore<CustomObfuscation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired", "CustomObfuscation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomObfuscation>.NativeClassPtr);
			CustomObfuscation.NativeFieldInfoPtr_rename = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomObfuscation>.NativeClassPtr, "rename");
			CustomObfuscation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomObfuscation>.NativeClassPtr, 100669484);
		}

		// Token: 0x06001A1E RID: 6686 RVA: 0x00092CBC File Offset: 0x00090EBC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomObfuscation()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomObfuscation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomObfuscation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A1F RID: 6687 RVA: 0x0000AAB9 File Offset: 0x00008CB9
		public CustomObfuscation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008A8 RID: 2216
		// (get) Token: 0x06001A20 RID: 6688 RVA: 0x00092CF8 File Offset: 0x00090EF8
		// (set) Token: 0x06001A21 RID: 6689 RVA: 0x0000AAC2 File Offset: 0x00008CC2
		public unsafe bool rename
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomObfuscation.NativeFieldInfoPtr_rename);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomObfuscation.NativeFieldInfoPtr_rename)) = value;
			}
		}

		// Token: 0x0400167F RID: 5759
		private static readonly IntPtr NativeFieldInfoPtr_rename;

		// Token: 0x04001680 RID: 5760
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
