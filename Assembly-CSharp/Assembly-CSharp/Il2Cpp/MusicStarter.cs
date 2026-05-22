using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000134 RID: 308
	public class MusicStarter : Glass
	{
		// Token: 0x06002648 RID: 9800 RVA: 0x0009E964 File Offset: 0x0009CB64
		// Note: this type is marked as 'beforefieldinit'.
		static MusicStarter()
		{
			Il2CppClassPointerStore<MusicStarter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "MusicStarter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicStarter>.NativeClassPtr);
			MusicStarter.NativeFieldInfoPtr_dontActuallyStartTheMusic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicStarter>.NativeClassPtr, "dontActuallyStartTheMusic");
			MusicStarter.NativeMethodInfoPtr_Break_Public_Virtual_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicStarter>.NativeClassPtr, 100666347);
			MusicStarter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicStarter>.NativeClassPtr, 100666348);
		}

		// Token: 0x06002649 RID: 9801 RVA: 0x0009E9D0 File Offset: 0x0009CBD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74350, XrefRangeEnd = 74362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Break(Vector2 pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MusicStarter.NativeMethodInfoPtr_Break_Public_Virtual_Void_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600264A RID: 9802 RVA: 0x0009EA1C File Offset: 0x0009CC1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MusicStarter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MusicStarter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicStarter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600264B RID: 9803 RVA: 0x0001AC02 File Offset: 0x00018E02
		public MusicStarter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000DD0 RID: 3536
		// (get) Token: 0x0600264C RID: 9804 RVA: 0x0009EA58 File Offset: 0x0009CC58
		// (set) Token: 0x0600264D RID: 9805 RVA: 0x0001AC0B File Offset: 0x00018E0B
		public unsafe bool dontActuallyStartTheMusic
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicStarter.NativeFieldInfoPtr_dontActuallyStartTheMusic);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicStarter.NativeFieldInfoPtr_dontActuallyStartTheMusic)) = value;
			}
		}

		// Token: 0x0400169A RID: 5786
		private static readonly IntPtr NativeFieldInfoPtr_dontActuallyStartTheMusic;

		// Token: 0x0400169B RID: 5787
		private static readonly IntPtr NativeMethodInfoPtr_Break_Public_Virtual_Void_Vector2_0;

		// Token: 0x0400169C RID: 5788
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
