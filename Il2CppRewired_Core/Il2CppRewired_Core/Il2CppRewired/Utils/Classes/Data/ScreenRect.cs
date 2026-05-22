using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppRewired.Utils.Classes.Data
{
	// Token: 0x020001CE RID: 462
	[Serializable]
	[StructLayout(2)]
	public struct ScreenRect
	{
		// Token: 0x06003086 RID: 12422 RVA: 0x000F1114 File Offset: 0x000EF314
		// Note: this type is marked as 'beforefieldinit'.
		static ScreenRect()
		{
			Il2CppClassPointerStore<ScreenRect>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Utils.Classes.Data", "ScreenRect");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScreenRect>.NativeClassPtr);
			ScreenRect.NativeFieldInfoPtr_xMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenRect>.NativeClassPtr, "xMin");
			ScreenRect.NativeFieldInfoPtr_yMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenRect>.NativeClassPtr, "yMin");
			ScreenRect.NativeFieldInfoPtr_width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenRect>.NativeClassPtr, "width");
			ScreenRect.NativeFieldInfoPtr_height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenRect>.NativeClassPtr, "height");
			ScreenRect.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenRect>.NativeClassPtr, 100675683);
			ScreenRect.NativeMethodInfoPtr_get_xMax_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenRect>.NativeClassPtr, 100675684);
			ScreenRect.NativeMethodInfoPtr_set_xMax_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenRect>.NativeClassPtr, 100675685);
			ScreenRect.NativeMethodInfoPtr_get_yMax_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenRect>.NativeClassPtr, 100675686);
			ScreenRect.NativeMethodInfoPtr_set_yMax_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenRect>.NativeClassPtr, 100675687);
			ScreenRect.NativeMethodInfoPtr_get_center_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenRect>.NativeClassPtr, 100675688);
			ScreenRect.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenRect>.NativeClassPtr, 100675689);
			ScreenRect.NativeMethodInfoPtr_op_Implicit_Public_Static_Rect_ScreenRect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenRect>.NativeClassPtr, 100675690);
			ScreenRect.NativeMethodInfoPtr_op_Implicit_Public_Static_ScreenRect_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenRect>.NativeClassPtr, 100675691);
		}

		// Token: 0x06003087 RID: 12423 RVA: 0x000F1248 File Offset: 0x000EF448
		[CallerCount(0)]
		public unsafe ScreenRect(float left, float bottom, float width, float height)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref left;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bottom;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenRect.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000F0C RID: 3852
		// (get) Token: 0x06003088 RID: 12424 RVA: 0x000F12A4 File Offset: 0x000EF4A4
		// (set) Token: 0x06003089 RID: 12425 RVA: 0x000F12D4 File Offset: 0x000EF4D4
		public unsafe float xMax
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenRect.NativeMethodInfoPtr_get_xMax_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenRect.NativeMethodInfoPtr_set_xMax_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000F0D RID: 3853
		// (get) Token: 0x0600308A RID: 12426 RVA: 0x000F1308 File Offset: 0x000EF508
		// (set) Token: 0x0600308B RID: 12427 RVA: 0x000F1338 File Offset: 0x000EF538
		public unsafe float yMax
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenRect.NativeMethodInfoPtr_get_yMax_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenRect.NativeMethodInfoPtr_set_yMax_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000F0E RID: 3854
		// (get) Token: 0x0600308C RID: 12428 RVA: 0x000F136C File Offset: 0x000EF56C
		public unsafe Vector2 center
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenRect.NativeMethodInfoPtr_get_center_Public_get_Vector2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600308D RID: 12429 RVA: 0x000F139C File Offset: 0x000EF59C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335343, XrefRangeEnd = 335375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenRect.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600308E RID: 12430 RVA: 0x000F13C8 File Offset: 0x000EF5C8
		[CallerCount(0)]
		public unsafe static implicit operator Rect(ScreenRect o)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref o;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenRect.NativeMethodInfoPtr_op_Implicit_Public_Static_Rect_ScreenRect_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600308F RID: 12431 RVA: 0x000F1408 File Offset: 0x000EF608
		[CallerCount(0)]
		public unsafe static implicit operator ScreenRect(Rect o)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref o;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenRect.NativeMethodInfoPtr_op_Implicit_Public_Static_ScreenRect_Rect_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003090 RID: 12432 RVA: 0x0001179B File Offset: 0x0000F99B
		public global::Il2CppSystem.Object BoxIl2CppObject()
		{
			return new global::Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ScreenRect>.NativeClassPtr, ref this));
		}

		// Token: 0x04002952 RID: 10578
		private static readonly IntPtr NativeFieldInfoPtr_xMin;

		// Token: 0x04002953 RID: 10579
		private static readonly IntPtr NativeFieldInfoPtr_yMin;

		// Token: 0x04002954 RID: 10580
		private static readonly IntPtr NativeFieldInfoPtr_width;

		// Token: 0x04002955 RID: 10581
		private static readonly IntPtr NativeFieldInfoPtr_height;

		// Token: 0x04002956 RID: 10582
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0;

		// Token: 0x04002957 RID: 10583
		private static readonly IntPtr NativeMethodInfoPtr_get_xMax_Public_get_Single_0;

		// Token: 0x04002958 RID: 10584
		private static readonly IntPtr NativeMethodInfoPtr_set_xMax_Public_set_Void_Single_0;

		// Token: 0x04002959 RID: 10585
		private static readonly IntPtr NativeMethodInfoPtr_get_yMax_Public_get_Single_0;

		// Token: 0x0400295A RID: 10586
		private static readonly IntPtr NativeMethodInfoPtr_set_yMax_Public_set_Void_Single_0;

		// Token: 0x0400295B RID: 10587
		private static readonly IntPtr NativeMethodInfoPtr_get_center_Public_get_Vector2_0;

		// Token: 0x0400295C RID: 10588
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400295D RID: 10589
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Rect_ScreenRect_0;

		// Token: 0x0400295E RID: 10590
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_ScreenRect_Rect_0;

		// Token: 0x0400295F RID: 10591
		[FieldOffset(0)]
		public float xMin;

		// Token: 0x04002960 RID: 10592
		[FieldOffset(4)]
		public float yMin;

		// Token: 0x04002961 RID: 10593
		[FieldOffset(8)]
		public float width;

		// Token: 0x04002962 RID: 10594
		[FieldOffset(12)]
		public float height;
	}
}
