using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200010D RID: 269
	[Serializable]
	public class LevelLine : global::Il2CppSystem.Object
	{
		// Token: 0x06002030 RID: 8240 RVA: 0x0008E6DC File Offset: 0x0008C8DC
		// Note: this type is marked as 'beforefieldinit'.
		static LevelLine()
		{
			Il2CppClassPointerStore<LevelLine>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "LevelLine");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LevelLine>.NativeClassPtr);
			LevelLine.NativeFieldInfoPtr_winLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelLine>.NativeClassPtr, "winLine");
			LevelLine.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelLine>.NativeClassPtr, 100665841);
		}

		// Token: 0x06002031 RID: 8241 RVA: 0x0008E734 File Offset: 0x0008C934
		[CallerCount(79)]
		[CachedScanResults(RefRangeStart = 14237, RefRangeEnd = 14316, XrefRangeStart = 14237, XrefRangeEnd = 14316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LevelLine(Il2CppStructArray<Vector2> a)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LevelLine>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelLine.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002032 RID: 8242 RVA: 0x00016831 File Offset: 0x00014A31
		public LevelLine(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B88 RID: 2952
		// (get) Token: 0x06002033 RID: 8243 RVA: 0x0008E780 File Offset: 0x0008C980
		// (set) Token: 0x06002034 RID: 8244 RVA: 0x0001683A File Offset: 0x00014A3A
		public unsafe Il2CppStructArray<Vector2> winLine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelLine.NativeFieldInfoPtr_winLine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelLine.NativeFieldInfoPtr_winLine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001319 RID: 4889
		private static readonly IntPtr NativeFieldInfoPtr_winLine;

		// Token: 0x0400131A RID: 4890
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Vector2_0;
	}
}
