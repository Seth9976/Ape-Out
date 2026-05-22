using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppRewired.Utils.Classes.Data
{
	// Token: 0x020001C1 RID: 449
	[Serializable]
	public class IntVector2 : global::Il2CppSystem.Object
	{
		// Token: 0x06002F39 RID: 12089 RVA: 0x000EB1B8 File Offset: 0x000E93B8
		// Note: this type is marked as 'beforefieldinit'.
		static IntVector2()
		{
			Il2CppClassPointerStore<IntVector2>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Utils.Classes.Data", "IntVector2");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntVector2>.NativeClassPtr);
			IntVector2.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntVector2>.NativeClassPtr, "x");
			IntVector2.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntVector2>.NativeClassPtr, "y");
			IntVector2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntVector2>.NativeClassPtr, 100675444);
			IntVector2.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntVector2>.NativeClassPtr, 100675445);
			IntVector2.NativeMethodInfoPtr_Clone_Public_IntVector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntVector2>.NativeClassPtr, 100675446);
			IntVector2.NativeMethodInfoPtr_Clone_Public_Static_IntVector2_IntVector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntVector2>.NativeClassPtr, 100675447);
			IntVector2.NativeMethodInfoPtr_op_Addition_Public_Static_IntVector2_IntVector2_IntVector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntVector2>.NativeClassPtr, 100675448);
			IntVector2.NativeMethodInfoPtr_op_Subtraction_Public_Static_IntVector2_IntVector2_IntVector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntVector2>.NativeClassPtr, 100675449);
			IntVector2.NativeMethodInfoPtr_op_Multiply_Public_Static_IntVector2_IntVector2_IntVector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntVector2>.NativeClassPtr, 100675450);
			IntVector2.NativeMethodInfoPtr_op_Division_Public_Static_IntVector2_IntVector2_IntVector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntVector2>.NativeClassPtr, 100675451);
			IntVector2.NativeMethodInfoPtr_op_Addition_Public_Static_IntVector2_IntVector2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntVector2>.NativeClassPtr, 100675452);
			IntVector2.NativeMethodInfoPtr_op_Subtraction_Public_Static_IntVector2_IntVector2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntVector2>.NativeClassPtr, 100675453);
			IntVector2.NativeMethodInfoPtr_op_Multiply_Public_Static_IntVector2_IntVector2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntVector2>.NativeClassPtr, 100675454);
			IntVector2.NativeMethodInfoPtr_op_Division_Public_Static_IntVector2_IntVector2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntVector2>.NativeClassPtr, 100675455);
			IntVector2.NativeMethodInfoPtr_op_Addition_Public_Static_Vector2_IntVector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntVector2>.NativeClassPtr, 100675456);
			IntVector2.NativeMethodInfoPtr_op_Subtraction_Public_Static_Vector2_IntVector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntVector2>.NativeClassPtr, 100675457);
			IntVector2.NativeMethodInfoPtr_op_Multiply_Public_Static_Vector2_IntVector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntVector2>.NativeClassPtr, 100675458);
			IntVector2.NativeMethodInfoPtr_op_Division_Public_Static_Vector2_IntVector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntVector2>.NativeClassPtr, 100675459);
		}

		// Token: 0x06002F3A RID: 12090 RVA: 0x000EB350 File Offset: 0x000E9550
		[CallerCount(0)]
		public unsafe IntVector2()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntVector2>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntVector2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F3B RID: 12091 RVA: 0x000EB38C File Offset: 0x000E958C
		[CallerCount(0)]
		public unsafe IntVector2(int inX, int inY)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntVector2>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref inX;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inY;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntVector2.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F3C RID: 12092 RVA: 0x000EB3E4 File Offset: 0x000E95E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334978, XrefRangeEnd = 334981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntVector2 Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntVector2.NativeMethodInfoPtr_Clone_Public_IntVector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IntVector2>(intPtr3) : null;
		}

		// Token: 0x06002F3D RID: 12093 RVA: 0x000EB424 File Offset: 0x000E9624
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334981, XrefRangeEnd = 334984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntVector2 Clone(IntVector2 intVector2)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(intVector2);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntVector2.NativeMethodInfoPtr_Clone_Public_Static_IntVector2_IntVector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IntVector2>(intPtr3) : null;
			}
		}

		// Token: 0x06002F3E RID: 12094 RVA: 0x000EB468 File Offset: 0x000E9668
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334984, XrefRangeEnd = 334987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntVector2 operator +(IntVector2 value1, IntVector2 value2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntVector2.NativeMethodInfoPtr_op_Addition_Public_Static_IntVector2_IntVector2_IntVector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IntVector2>(intPtr3) : null;
		}

		// Token: 0x06002F3F RID: 12095 RVA: 0x000EB4C0 File Offset: 0x000E96C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334987, XrefRangeEnd = 334990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntVector2 operator -(IntVector2 value1, IntVector2 value2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntVector2.NativeMethodInfoPtr_op_Subtraction_Public_Static_IntVector2_IntVector2_IntVector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IntVector2>(intPtr3) : null;
		}

		// Token: 0x06002F40 RID: 12096 RVA: 0x000EB518 File Offset: 0x000E9718
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334990, XrefRangeEnd = 334993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntVector2 operator *(IntVector2 value1, IntVector2 value2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntVector2.NativeMethodInfoPtr_op_Multiply_Public_Static_IntVector2_IntVector2_IntVector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IntVector2>(intPtr3) : null;
		}

		// Token: 0x06002F41 RID: 12097 RVA: 0x000EB570 File Offset: 0x000E9770
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334993, XrefRangeEnd = 334996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntVector2 operator /(IntVector2 value1, IntVector2 value2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntVector2.NativeMethodInfoPtr_op_Division_Public_Static_IntVector2_IntVector2_IntVector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IntVector2>(intPtr3) : null;
		}

		// Token: 0x06002F42 RID: 12098 RVA: 0x000EB5C8 File Offset: 0x000E97C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334996, XrefRangeEnd = 334999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntVector2 operator +(IntVector2 value1, int value2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntVector2.NativeMethodInfoPtr_op_Addition_Public_Static_IntVector2_IntVector2_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IntVector2>(intPtr3) : null;
		}

		// Token: 0x06002F43 RID: 12099 RVA: 0x000EB61C File Offset: 0x000E981C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334999, XrefRangeEnd = 335002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntVector2 operator -(IntVector2 value1, int value2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntVector2.NativeMethodInfoPtr_op_Subtraction_Public_Static_IntVector2_IntVector2_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IntVector2>(intPtr3) : null;
		}

		// Token: 0x06002F44 RID: 12100 RVA: 0x000EB670 File Offset: 0x000E9870
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335002, XrefRangeEnd = 335005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntVector2 operator *(IntVector2 value1, int value2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntVector2.NativeMethodInfoPtr_op_Multiply_Public_Static_IntVector2_IntVector2_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IntVector2>(intPtr3) : null;
		}

		// Token: 0x06002F45 RID: 12101 RVA: 0x000EB6C4 File Offset: 0x000E98C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335005, XrefRangeEnd = 335008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntVector2 operator /(IntVector2 value1, int value2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntVector2.NativeMethodInfoPtr_op_Division_Public_Static_IntVector2_IntVector2_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IntVector2>(intPtr3) : null;
		}

		// Token: 0x06002F46 RID: 12102 RVA: 0x000EB718 File Offset: 0x000E9918
		[CallerCount(0)]
		public unsafe static Vector2 operator +(IntVector2 value1, float value2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntVector2.NativeMethodInfoPtr_op_Addition_Public_Static_Vector2_IntVector2_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002F47 RID: 12103 RVA: 0x000EB768 File Offset: 0x000E9968
		[CallerCount(0)]
		public unsafe static Vector2 operator -(IntVector2 value1, float value2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntVector2.NativeMethodInfoPtr_op_Subtraction_Public_Static_Vector2_IntVector2_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002F48 RID: 12104 RVA: 0x000EB7B8 File Offset: 0x000E99B8
		[CallerCount(0)]
		public unsafe static Vector2 operator *(IntVector2 value1, float value2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntVector2.NativeMethodInfoPtr_op_Multiply_Public_Static_Vector2_IntVector2_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002F49 RID: 12105 RVA: 0x000EB808 File Offset: 0x000E9A08
		[CallerCount(0)]
		public unsafe static Vector2 operator /(IntVector2 value1, float value2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntVector2.NativeMethodInfoPtr_op_Division_Public_Static_Vector2_IntVector2_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002F4A RID: 12106 RVA: 0x000113E4 File Offset: 0x0000F5E4
		public IntVector2(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000EDB RID: 3803
		// (get) Token: 0x06002F4B RID: 12107 RVA: 0x000EB858 File Offset: 0x000E9A58
		// (set) Token: 0x06002F4C RID: 12108 RVA: 0x000113ED File Offset: 0x0000F5ED
		public unsafe int x
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntVector2.NativeFieldInfoPtr_x);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntVector2.NativeFieldInfoPtr_x)) = value;
			}
		}

		// Token: 0x17000EDC RID: 3804
		// (get) Token: 0x06002F4D RID: 12109 RVA: 0x000EB880 File Offset: 0x000E9A80
		// (set) Token: 0x06002F4E RID: 12110 RVA: 0x00011408 File Offset: 0x0000F608
		public unsafe int y
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntVector2.NativeFieldInfoPtr_y);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntVector2.NativeFieldInfoPtr_y)) = value;
			}
		}

		// Token: 0x040027FD RID: 10237
		private static readonly IntPtr NativeFieldInfoPtr_x;

		// Token: 0x040027FE RID: 10238
		private static readonly IntPtr NativeFieldInfoPtr_y;

		// Token: 0x040027FF RID: 10239
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002800 RID: 10240
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;

		// Token: 0x04002801 RID: 10241
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_IntVector2_0;

		// Token: 0x04002802 RID: 10242
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Static_IntVector2_IntVector2_0;

		// Token: 0x04002803 RID: 10243
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_IntVector2_IntVector2_IntVector2_0;

		// Token: 0x04002804 RID: 10244
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_IntVector2_IntVector2_IntVector2_0;

		// Token: 0x04002805 RID: 10245
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_IntVector2_IntVector2_IntVector2_0;

		// Token: 0x04002806 RID: 10246
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_IntVector2_IntVector2_IntVector2_0;

		// Token: 0x04002807 RID: 10247
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_IntVector2_IntVector2_Int32_0;

		// Token: 0x04002808 RID: 10248
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_IntVector2_IntVector2_Int32_0;

		// Token: 0x04002809 RID: 10249
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_IntVector2_IntVector2_Int32_0;

		// Token: 0x0400280A RID: 10250
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_IntVector2_IntVector2_Int32_0;

		// Token: 0x0400280B RID: 10251
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_Vector2_IntVector2_Single_0;

		// Token: 0x0400280C RID: 10252
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_Vector2_IntVector2_Single_0;

		// Token: 0x0400280D RID: 10253
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_Vector2_IntVector2_Single_0;

		// Token: 0x0400280E RID: 10254
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_Vector2_IntVector2_Single_0;
	}
}
