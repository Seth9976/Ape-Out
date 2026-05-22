using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UI
{
	// Token: 0x0200000C RID: 12
	public class RectangularVertexClipper : Object
	{
		// Token: 0x0600008C RID: 140 RVA: 0x00008DD8 File Offset: 0x00006FD8
		// Note: this type is marked as 'beforefieldinit'.
		static RectangularVertexClipper()
		{
			Il2CppClassPointerStore<RectangularVertexClipper>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "RectangularVertexClipper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RectangularVertexClipper>.NativeClassPtr);
			RectangularVertexClipper.NativeFieldInfoPtr_m_WorldCorners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectangularVertexClipper>.NativeClassPtr, "m_WorldCorners");
			RectangularVertexClipper.NativeFieldInfoPtr_m_CanvasCorners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectangularVertexClipper>.NativeClassPtr, "m_CanvasCorners");
			RectangularVertexClipper.NativeMethodInfoPtr_GetCanvasRect_Public_Rect_RectTransform_Canvas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectangularVertexClipper>.NativeClassPtr, 100663383);
			RectangularVertexClipper.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectangularVertexClipper>.NativeClassPtr, 100663384);
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00008E58 File Offset: 0x00007058
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 516284, RefRangeEnd = 516287, XrefRangeStart = 516266, XrefRangeEnd = 516284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Rect GetCanvasRect(RectTransform t, Canvas c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(c);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectangularVertexClipper.NativeMethodInfoPtr_GetCanvasRect_Public_Rect_RectTransform_Canvas_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00008EB8 File Offset: 0x000070B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 516287, XrefRangeEnd = 516292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RectangularVertexClipper()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RectangularVertexClipper>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectangularVertexClipper.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600008F RID: 143 RVA: 0x0000232E File Offset: 0x0000052E
		public RectangularVertexClipper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000090 RID: 144 RVA: 0x00008EF4 File Offset: 0x000070F4
		// (set) Token: 0x06000091 RID: 145 RVA: 0x00002337 File Offset: 0x00000537
		public unsafe Il2CppStructArray<Vector3> m_WorldCorners
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectangularVertexClipper.NativeFieldInfoPtr_m_WorldCorners);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectangularVertexClipper.NativeFieldInfoPtr_m_WorldCorners), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000092 RID: 146 RVA: 0x00008F24 File Offset: 0x00007124
		// (set) Token: 0x06000093 RID: 147 RVA: 0x00002356 File Offset: 0x00000556
		public unsafe Il2CppStructArray<Vector3> m_CanvasCorners
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectangularVertexClipper.NativeFieldInfoPtr_m_CanvasCorners);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectangularVertexClipper.NativeFieldInfoPtr_m_CanvasCorners), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000079 RID: 121
		private static readonly IntPtr NativeFieldInfoPtr_m_WorldCorners;

		// Token: 0x0400007A RID: 122
		private static readonly IntPtr NativeFieldInfoPtr_m_CanvasCorners;

		// Token: 0x0400007B RID: 123
		private static readonly IntPtr NativeMethodInfoPtr_GetCanvasRect_Public_Rect_RectTransform_Canvas_0;

		// Token: 0x0400007C RID: 124
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
