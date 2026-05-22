using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppRewired.Utils.Attributes
{
	// Token: 0x02000006 RID: 6
	public class FieldRangeAttribute : PropertyAttribute
	{
		// Token: 0x0600001C RID: 28 RVA: 0x0002CB14 File Offset: 0x0002AD14
		// Note: this type is marked as 'beforefieldinit'.
		static FieldRangeAttribute()
		{
			Il2CppClassPointerStore<FieldRangeAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Utils.Attributes", "FieldRangeAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FieldRangeAttribute>.NativeClassPtr);
			FieldRangeAttribute.NativeFieldInfoPtr_jUbgziSjIqPOeBYdOupeXjKGZku = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FieldRangeAttribute>.NativeClassPtr, "jUbgziSjIqPOeBYdOupeXjKGZku");
			FieldRangeAttribute.NativeFieldInfoPtr_sKOCOedUhMFOfCjZtIeORcQqAGQ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FieldRangeAttribute>.NativeClassPtr, "sKOCOedUhMFOfCjZtIeORcQqAGQ");
			FieldRangeAttribute.NativeFieldInfoPtr_gjngRLhUUiQGKIPDWbCHLOyxZJOr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FieldRangeAttribute>.NativeClassPtr, "gjngRLhUUiQGKIPDWbCHLOyxZJOr");
			FieldRangeAttribute.NativeFieldInfoPtr_pjxDlZbfAMidLsZVKKnmFZnJqgLa = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FieldRangeAttribute>.NativeClassPtr, "pjxDlZbfAMidLsZVKKnmFZnJqgLa");
			FieldRangeAttribute.NativeMethodInfoPtr_get_minFloat_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldRangeAttribute>.NativeClassPtr, 100663302);
			FieldRangeAttribute.NativeMethodInfoPtr_get_maxFloat_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldRangeAttribute>.NativeClassPtr, 100663303);
			FieldRangeAttribute.NativeMethodInfoPtr_get_minInt_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldRangeAttribute>.NativeClassPtr, 100663304);
			FieldRangeAttribute.NativeMethodInfoPtr_get_maxInt_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldRangeAttribute>.NativeClassPtr, 100663305);
			FieldRangeAttribute.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldRangeAttribute>.NativeClassPtr, 100663306);
			FieldRangeAttribute.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldRangeAttribute>.NativeClassPtr, 100663307);
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600001D RID: 29 RVA: 0x0002CC0C File Offset: 0x0002AE0C
		public unsafe float minFloat
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldRangeAttribute.NativeMethodInfoPtr_get_minFloat_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600001E RID: 30 RVA: 0x0002CC48 File Offset: 0x0002AE48
		public unsafe float maxFloat
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldRangeAttribute.NativeMethodInfoPtr_get_maxFloat_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600001F RID: 31 RVA: 0x0002CC84 File Offset: 0x0002AE84
		public unsafe int minInt
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldRangeAttribute.NativeMethodInfoPtr_get_minInt_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000020 RID: 32 RVA: 0x0002CCC0 File Offset: 0x0002AEC0
		public unsafe int maxInt
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldRangeAttribute.NativeMethodInfoPtr_get_maxInt_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000021 RID: 33 RVA: 0x0002CCFC File Offset: 0x0002AEFC
		[CallerCount(0)]
		public unsafe FieldRangeAttribute(float min, float max)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FieldRangeAttribute>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref min;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldRangeAttribute.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000022 RID: 34 RVA: 0x0002CD54 File Offset: 0x0002AF54
		[CallerCount(0)]
		public unsafe FieldRangeAttribute(int min, int max)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FieldRangeAttribute>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref min;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldRangeAttribute.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002145 File Offset: 0x00000345
		public FieldRangeAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000024 RID: 36 RVA: 0x0002CDAC File Offset: 0x0002AFAC
		// (set) Token: 0x06000025 RID: 37 RVA: 0x0000214E File Offset: 0x0000034E
		public unsafe float jUbgziSjIqPOeBYdOupeXjKGZku
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldRangeAttribute.NativeFieldInfoPtr_jUbgziSjIqPOeBYdOupeXjKGZku);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldRangeAttribute.NativeFieldInfoPtr_jUbgziSjIqPOeBYdOupeXjKGZku)) = value;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000026 RID: 38 RVA: 0x0002CDD4 File Offset: 0x0002AFD4
		// (set) Token: 0x06000027 RID: 39 RVA: 0x00002169 File Offset: 0x00000369
		public unsafe float sKOCOedUhMFOfCjZtIeORcQqAGQ
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldRangeAttribute.NativeFieldInfoPtr_sKOCOedUhMFOfCjZtIeORcQqAGQ);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldRangeAttribute.NativeFieldInfoPtr_sKOCOedUhMFOfCjZtIeORcQqAGQ)) = value;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000028 RID: 40 RVA: 0x0002CDFC File Offset: 0x0002AFFC
		// (set) Token: 0x06000029 RID: 41 RVA: 0x00002184 File Offset: 0x00000384
		public unsafe int gjngRLhUUiQGKIPDWbCHLOyxZJOr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldRangeAttribute.NativeFieldInfoPtr_gjngRLhUUiQGKIPDWbCHLOyxZJOr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldRangeAttribute.NativeFieldInfoPtr_gjngRLhUUiQGKIPDWbCHLOyxZJOr)) = value;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600002A RID: 42 RVA: 0x0002CE24 File Offset: 0x0002B024
		// (set) Token: 0x0600002B RID: 43 RVA: 0x0000219F File Offset: 0x0000039F
		public unsafe int pjxDlZbfAMidLsZVKKnmFZnJqgLa
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldRangeAttribute.NativeFieldInfoPtr_pjxDlZbfAMidLsZVKKnmFZnJqgLa);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldRangeAttribute.NativeFieldInfoPtr_pjxDlZbfAMidLsZVKKnmFZnJqgLa)) = value;
			}
		}

		// Token: 0x0400000D RID: 13
		private static readonly IntPtr NativeFieldInfoPtr_jUbgziSjIqPOeBYdOupeXjKGZku;

		// Token: 0x0400000E RID: 14
		private static readonly IntPtr NativeFieldInfoPtr_sKOCOedUhMFOfCjZtIeORcQqAGQ;

		// Token: 0x0400000F RID: 15
		private static readonly IntPtr NativeFieldInfoPtr_gjngRLhUUiQGKIPDWbCHLOyxZJOr;

		// Token: 0x04000010 RID: 16
		private static readonly IntPtr NativeFieldInfoPtr_pjxDlZbfAMidLsZVKKnmFZnJqgLa;

		// Token: 0x04000011 RID: 17
		private static readonly IntPtr NativeMethodInfoPtr_get_minFloat_Public_get_Single_0;

		// Token: 0x04000012 RID: 18
		private static readonly IntPtr NativeMethodInfoPtr_get_maxFloat_Public_get_Single_0;

		// Token: 0x04000013 RID: 19
		private static readonly IntPtr NativeMethodInfoPtr_get_minInt_Public_get_Int32_0;

		// Token: 0x04000014 RID: 20
		private static readonly IntPtr NativeMethodInfoPtr_get_maxInt_Public_get_Int32_0;

		// Token: 0x04000015 RID: 21
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0;

		// Token: 0x04000016 RID: 22
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;
	}
}
