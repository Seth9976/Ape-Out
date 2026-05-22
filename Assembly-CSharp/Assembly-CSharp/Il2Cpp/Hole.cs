using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200010E RID: 270
	public class Hole : MonoBehaviour
	{
		// Token: 0x06002035 RID: 8245 RVA: 0x0008E7B0 File Offset: 0x0008C9B0
		// Note: this type is marked as 'beforefieldinit'.
		static Hole()
		{
			Il2CppClassPointerStore<Hole>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Hole");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Hole>.NativeClassPtr);
			Hole.NativeFieldInfoPtr_t = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hole>.NativeClassPtr, "t");
			Hole.NativeMethodInfoPtr_FixedUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hole>.NativeClassPtr, 100665842);
			Hole.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hole>.NativeClassPtr, 100665843);
		}

		// Token: 0x06002036 RID: 8246 RVA: 0x0008E81C File Offset: 0x0008CA1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67466, XrefRangeEnd = 67474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hole.NativeMethodInfoPtr_FixedUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002037 RID: 8247 RVA: 0x0008E850 File Offset: 0x0008CA50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Hole()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Hole>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hole.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002038 RID: 8248 RVA: 0x00016859 File Offset: 0x00014A59
		public Hole(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B89 RID: 2953
		// (get) Token: 0x06002039 RID: 8249 RVA: 0x0008E88C File Offset: 0x0008CA8C
		// (set) Token: 0x0600203A RID: 8250 RVA: 0x00016862 File Offset: 0x00014A62
		public unsafe int t
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hole.NativeFieldInfoPtr_t);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hole.NativeFieldInfoPtr_t)) = value;
			}
		}

		// Token: 0x0400131B RID: 4891
		private static readonly IntPtr NativeFieldInfoPtr_t;

		// Token: 0x0400131C RID: 4892
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Public_Void_0;

		// Token: 0x0400131D RID: 4893
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
