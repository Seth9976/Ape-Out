using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000385 RID: 901
	[Serializable]
	public sealed class IntSizedArray : Object
	{
		// Token: 0x06003BA6 RID: 15270 RVA: 0x0011CC80 File Offset: 0x0011AE80
		// Note: this type is marked as 'beforefieldinit'.
		static IntSizedArray()
		{
			Il2CppClassPointerStore<IntSizedArray>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "IntSizedArray");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntSizedArray>.NativeClassPtr);
			IntSizedArray.NativeFieldInfoPtr_objects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntSizedArray>.NativeClassPtr, "objects");
			IntSizedArray.NativeFieldInfoPtr_negObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntSizedArray>.NativeClassPtr, "negObjects");
			IntSizedArray.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntSizedArray>.NativeClassPtr, 100672223);
			IntSizedArray.NativeMethodInfoPtr__ctor_Private_Void_IntSizedArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntSizedArray>.NativeClassPtr, 100672224);
			IntSizedArray.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntSizedArray>.NativeClassPtr, 100672225);
			IntSizedArray.NativeMethodInfoPtr_get_Item_Internal_get_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntSizedArray>.NativeClassPtr, 100672226);
			IntSizedArray.NativeMethodInfoPtr_set_Item_Internal_set_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntSizedArray>.NativeClassPtr, 100672227);
			IntSizedArray.NativeMethodInfoPtr_IncreaseCapacity_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntSizedArray>.NativeClassPtr, 100672228);
		}

		// Token: 0x06003BA7 RID: 15271 RVA: 0x0011CD50 File Offset: 0x0011AF50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218930, XrefRangeEnd = 218935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntSizedArray()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntSizedArray>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntSizedArray.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003BA8 RID: 15272 RVA: 0x0011CD8C File Offset: 0x0011AF8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 218947, RefRangeEnd = 218948, XrefRangeStart = 218935, XrefRangeEnd = 218947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntSizedArray(IntSizedArray sizedArray)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntSizedArray>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sizedArray);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntSizedArray.NativeMethodInfoPtr__ctor_Private_Void_IntSizedArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003BA9 RID: 15273 RVA: 0x0011CDD8 File Offset: 0x0011AFD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218948, XrefRangeEnd = 218952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntSizedArray.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x17000EC5 RID: 3781
		public unsafe int this[int index]
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218952, XrefRangeEnd = 218953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntSizedArray.NativeMethodInfoPtr_get_Item_Internal_get_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218953, XrefRangeEnd = 218954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntSizedArray.NativeMethodInfoPtr_set_Item_Internal_set_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003BAC RID: 15276 RVA: 0x0011CEB0 File Offset: 0x0011B0B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 218967, RefRangeEnd = 218968, XrefRangeStart = 218954, XrefRangeEnd = 218967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void IncreaseCapacity(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntSizedArray.NativeMethodInfoPtr_IncreaseCapacity_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003BAD RID: 15277 RVA: 0x0001619F File Offset: 0x0001439F
		public IntSizedArray(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000EC3 RID: 3779
		// (get) Token: 0x06003BAE RID: 15278 RVA: 0x0011CEF0 File Offset: 0x0011B0F0
		// (set) Token: 0x06003BAF RID: 15279 RVA: 0x000161A8 File Offset: 0x000143A8
		public unsafe Il2CppStructArray<int> objects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntSizedArray.NativeFieldInfoPtr_objects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntSizedArray.NativeFieldInfoPtr_objects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EC4 RID: 3780
		// (get) Token: 0x06003BB0 RID: 15280 RVA: 0x0011CF20 File Offset: 0x0011B120
		// (set) Token: 0x06003BB1 RID: 15281 RVA: 0x000161C7 File Offset: 0x000143C7
		public unsafe Il2CppStructArray<int> negObjects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntSizedArray.NativeFieldInfoPtr_negObjects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntSizedArray.NativeFieldInfoPtr_negObjects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040031C7 RID: 12743
		private static readonly IntPtr NativeFieldInfoPtr_objects;

		// Token: 0x040031C8 RID: 12744
		private static readonly IntPtr NativeFieldInfoPtr_negObjects;

		// Token: 0x040031C9 RID: 12745
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040031CA RID: 12746
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_IntSizedArray_0;

		// Token: 0x040031CB RID: 12747
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;

		// Token: 0x040031CC RID: 12748
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Internal_get_Int32_Int32_0;

		// Token: 0x040031CD RID: 12749
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Internal_set_Void_Int32_Int32_0;

		// Token: 0x040031CE RID: 12750
		private static readonly IntPtr NativeMethodInfoPtr_IncreaseCapacity_Internal_Void_Int32_0;
	}
}
