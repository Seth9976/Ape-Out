using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppRewired.UI
{
	// Token: 0x02000036 RID: 54
	[StructLayout(2)]
	public struct UIPivot
	{
		// Token: 0x06000402 RID: 1026 RVA: 0x0003D104 File Offset: 0x0003B304
		// Note: this type is marked as 'beforefieldinit'.
		static UIPivot()
		{
			Il2CppClassPointerStore<UIPivot>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.UI", "UIPivot");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIPivot>.NativeClassPtr);
			UIPivot.NativeFieldInfoPtr_min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPivot>.NativeClassPtr, "min");
			UIPivot.NativeFieldInfoPtr_max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPivot>.NativeClassPtr, "max");
			UIPivot.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPivot>.NativeClassPtr, 100663979);
			UIPivot.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector2_UIPivot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPivot>.NativeClassPtr, 100663980);
			UIPivot.NativeMethodInfoPtr_op_Implicit_Public_Static_UIPivot_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPivot>.NativeClassPtr, 100663981);
			UIPivot.NativeMethodInfoPtr_get_TopLeft_Public_Static_get_UIPivot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPivot>.NativeClassPtr, 100663982);
			UIPivot.NativeMethodInfoPtr_get_TopCenter_Public_Static_get_UIPivot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPivot>.NativeClassPtr, 100663983);
			UIPivot.NativeMethodInfoPtr_get_TopRight_Public_Static_get_UIPivot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPivot>.NativeClassPtr, 100663984);
			UIPivot.NativeMethodInfoPtr_get_MiddleLeft_Public_Static_get_UIPivot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPivot>.NativeClassPtr, 100663985);
			UIPivot.NativeMethodInfoPtr_get_MiddleCenter_Public_Static_get_UIPivot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPivot>.NativeClassPtr, 100663986);
			UIPivot.NativeMethodInfoPtr_get_MiddleRight_Public_Static_get_UIPivot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPivot>.NativeClassPtr, 100663987);
			UIPivot.NativeMethodInfoPtr_get_BottomLeft_Public_Static_get_UIPivot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPivot>.NativeClassPtr, 100663988);
			UIPivot.NativeMethodInfoPtr_get_BottomCenter_Public_Static_get_UIPivot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPivot>.NativeClassPtr, 100663989);
			UIPivot.NativeMethodInfoPtr_get_BottomRight_Public_Static_get_UIPivot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPivot>.NativeClassPtr, 100663990);
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x0003D24C File Offset: 0x0003B44C
		[CallerCount(0)]
		public unsafe UIPivot(float min, float max)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref min;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPivot.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x0003D28C File Offset: 0x0003B48C
		[CallerCount(0)]
		public unsafe static implicit operator Vector2(UIPivot x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPivot.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector2_UIPivot_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x0003D2CC File Offset: 0x0003B4CC
		[CallerCount(0)]
		public unsafe static implicit operator UIPivot(Vector2 x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPivot.NativeMethodInfoPtr_op_Implicit_Public_Static_UIPivot_Vector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x06000406 RID: 1030 RVA: 0x0003D30C File Offset: 0x0003B50C
		public unsafe static UIPivot TopLeft
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPivot.NativeMethodInfoPtr_get_TopLeft_Public_Static_get_UIPivot_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x06000407 RID: 1031 RVA: 0x0003D33C File Offset: 0x0003B53C
		public unsafe static UIPivot TopCenter
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPivot.NativeMethodInfoPtr_get_TopCenter_Public_Static_get_UIPivot_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x06000408 RID: 1032 RVA: 0x0003D36C File Offset: 0x0003B56C
		public unsafe static UIPivot TopRight
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPivot.NativeMethodInfoPtr_get_TopRight_Public_Static_get_UIPivot_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x06000409 RID: 1033 RVA: 0x0003D39C File Offset: 0x0003B59C
		public unsafe static UIPivot MiddleLeft
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPivot.NativeMethodInfoPtr_get_MiddleLeft_Public_Static_get_UIPivot_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x0600040A RID: 1034 RVA: 0x0003D3CC File Offset: 0x0003B5CC
		public unsafe static UIPivot MiddleCenter
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPivot.NativeMethodInfoPtr_get_MiddleCenter_Public_Static_get_UIPivot_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x0600040B RID: 1035 RVA: 0x0003D3FC File Offset: 0x0003B5FC
		public unsafe static UIPivot MiddleRight
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPivot.NativeMethodInfoPtr_get_MiddleRight_Public_Static_get_UIPivot_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x0600040C RID: 1036 RVA: 0x0003D42C File Offset: 0x0003B62C
		public unsafe static UIPivot BottomLeft
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPivot.NativeMethodInfoPtr_get_BottomLeft_Public_Static_get_UIPivot_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x0600040D RID: 1037 RVA: 0x0003D45C File Offset: 0x0003B65C
		public unsafe static UIPivot BottomCenter
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPivot.NativeMethodInfoPtr_get_BottomCenter_Public_Static_get_UIPivot_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x0600040E RID: 1038 RVA: 0x0003D48C File Offset: 0x0003B68C
		public unsafe static UIPivot BottomRight
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPivot.NativeMethodInfoPtr_get_BottomRight_Public_Static_get_UIPivot_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x0000342B File Offset: 0x0000162B
		public global::Il2CppSystem.Object BoxIl2CppObject()
		{
			return new global::Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UIPivot>.NativeClassPtr, ref this));
		}

		// Token: 0x04000375 RID: 885
		private static readonly IntPtr NativeFieldInfoPtr_min;

		// Token: 0x04000376 RID: 886
		private static readonly IntPtr NativeFieldInfoPtr_max;

		// Token: 0x04000377 RID: 887
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0;

		// Token: 0x04000378 RID: 888
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Vector2_UIPivot_0;

		// Token: 0x04000379 RID: 889
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_UIPivot_Vector2_0;

		// Token: 0x0400037A RID: 890
		private static readonly IntPtr NativeMethodInfoPtr_get_TopLeft_Public_Static_get_UIPivot_0;

		// Token: 0x0400037B RID: 891
		private static readonly IntPtr NativeMethodInfoPtr_get_TopCenter_Public_Static_get_UIPivot_0;

		// Token: 0x0400037C RID: 892
		private static readonly IntPtr NativeMethodInfoPtr_get_TopRight_Public_Static_get_UIPivot_0;

		// Token: 0x0400037D RID: 893
		private static readonly IntPtr NativeMethodInfoPtr_get_MiddleLeft_Public_Static_get_UIPivot_0;

		// Token: 0x0400037E RID: 894
		private static readonly IntPtr NativeMethodInfoPtr_get_MiddleCenter_Public_Static_get_UIPivot_0;

		// Token: 0x0400037F RID: 895
		private static readonly IntPtr NativeMethodInfoPtr_get_MiddleRight_Public_Static_get_UIPivot_0;

		// Token: 0x04000380 RID: 896
		private static readonly IntPtr NativeMethodInfoPtr_get_BottomLeft_Public_Static_get_UIPivot_0;

		// Token: 0x04000381 RID: 897
		private static readonly IntPtr NativeMethodInfoPtr_get_BottomCenter_Public_Static_get_UIPivot_0;

		// Token: 0x04000382 RID: 898
		private static readonly IntPtr NativeMethodInfoPtr_get_BottomRight_Public_Static_get_UIPivot_0;

		// Token: 0x04000383 RID: 899
		[FieldOffset(0)]
		public float min;

		// Token: 0x04000384 RID: 900
		[FieldOffset(4)]
		public float max;
	}
}
