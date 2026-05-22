using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x020000A0 RID: 160
	public class CanopyMaker : MonoBehaviour
	{
		// Token: 0x060013CB RID: 5067 RVA: 0x0006C7B4 File Offset: 0x0006A9B4
		// Note: this type is marked as 'beforefieldinit'.
		static CanopyMaker()
		{
			Il2CppClassPointerStore<CanopyMaker>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "CanopyMaker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CanopyMaker>.NativeClassPtr);
			CanopyMaker.NativeFieldInfoPtr_leaves = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanopyMaker>.NativeClassPtr, "leaves");
			CanopyMaker.NativeFieldInfoPtr_leafNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanopyMaker>.NativeClassPtr, "leafNum");
			CanopyMaker.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanopyMaker>.NativeClassPtr, 100664977);
		}

		// Token: 0x060013CC RID: 5068 RVA: 0x0006C820 File Offset: 0x0006AA20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CanopyMaker()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CanopyMaker>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanopyMaker.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013CD RID: 5069 RVA: 0x0000E815 File Offset: 0x0000CA15
		public CanopyMaker(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000732 RID: 1842
		// (get) Token: 0x060013CE RID: 5070 RVA: 0x0006C85C File Offset: 0x0006AA5C
		// (set) Token: 0x060013CF RID: 5071 RVA: 0x0000E81E File Offset: 0x0000CA1E
		public unsafe Il2CppReferenceArray<GameObject> leaves
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanopyMaker.NativeFieldInfoPtr_leaves);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanopyMaker.NativeFieldInfoPtr_leaves), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000733 RID: 1843
		// (get) Token: 0x060013D0 RID: 5072 RVA: 0x0006C88C File Offset: 0x0006AA8C
		// (set) Token: 0x060013D1 RID: 5073 RVA: 0x0000E83D File Offset: 0x0000CA3D
		public unsafe int leafNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanopyMaker.NativeFieldInfoPtr_leafNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanopyMaker.NativeFieldInfoPtr_leafNum)) = value;
			}
		}

		// Token: 0x04000BDC RID: 3036
		private static readonly IntPtr NativeFieldInfoPtr_leaves;

		// Token: 0x04000BDD RID: 3037
		private static readonly IntPtr NativeFieldInfoPtr_leafNum;

		// Token: 0x04000BDE RID: 3038
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
