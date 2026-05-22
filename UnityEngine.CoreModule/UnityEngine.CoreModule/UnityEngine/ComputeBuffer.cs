using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.InteropServices;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;

namespace UnityEngine
{
	// Token: 0x020000F6 RID: 246
	public sealed class ComputeBuffer : Object
	{
		// Token: 0x06001426 RID: 5158 RVA: 0x00051660 File Offset: 0x0004F860
		// Note: this type is marked as 'beforefieldinit'.
		static ComputeBuffer()
		{
			Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "ComputeBuffer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr);
			ComputeBuffer.NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr, "m_Ptr");
			ComputeBuffer.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr, 100665075);
			ComputeBuffer.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr, 100665076);
			ComputeBuffer.NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr, 100665077);
			ComputeBuffer.NativeMethodInfoPtr_InitBuffer_Private_Static_IntPtr_Int32_Int32_ComputeBufferType_ComputeBufferMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr, 100665078);
			ComputeBuffer.NativeMethodInfoPtr_DestroyBuffer_Private_Static_Void_ComputeBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr, 100665079);
			ComputeBuffer.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr, 100665080);
			ComputeBuffer.NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_ComputeBufferType_ComputeBufferMode_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr, 100665081);
			ComputeBuffer.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr, 100665082);
			ComputeBuffer.NativeMethodInfoPtr_get_count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr, 100665083);
			ComputeBuffer.get_strideDelegateField = IL2CPP.ResolveICall<ComputeBuffer.get_strideDelegate>("UnityEngine.ComputeBuffer::get_stride");
			ComputeBuffer.get_usageDelegateField = IL2CPP.ResolveICall<ComputeBuffer.get_usageDelegate>("UnityEngine.ComputeBuffer::get_usage");
			ComputeBuffer.InternalSetNativeDataDelegateField = IL2CPP.ResolveICall<ComputeBuffer.InternalSetNativeDataDelegate>("UnityEngine.ComputeBuffer::InternalSetNativeData");
			ComputeBuffer.InternalSetDataDelegateField = IL2CPP.ResolveICall<ComputeBuffer.InternalSetDataDelegate>("UnityEngine.ComputeBuffer::InternalSetData");
			ComputeBuffer.InternalGetDataDelegateField = IL2CPP.ResolveICall<ComputeBuffer.InternalGetDataDelegate>("UnityEngine.ComputeBuffer::InternalGetData");
			ComputeBuffer.BeginBufferWriteDelegateField = IL2CPP.ResolveICall<ComputeBuffer.BeginBufferWriteDelegate>("UnityEngine.ComputeBuffer::BeginBufferWrite");
			ComputeBuffer.EndBufferWriteDelegateField = IL2CPP.ResolveICall<ComputeBuffer.EndBufferWriteDelegate>("UnityEngine.ComputeBuffer::EndBufferWrite");
			ComputeBuffer.SetNameDelegateField = IL2CPP.ResolveICall<ComputeBuffer.SetNameDelegate>("UnityEngine.ComputeBuffer::SetName");
			ComputeBuffer.SetCounterValueDelegateField = IL2CPP.ResolveICall<ComputeBuffer.SetCounterValueDelegate>("UnityEngine.ComputeBuffer::SetCounterValue");
			ComputeBuffer.CopyCountDelegateField = IL2CPP.ResolveICall<ComputeBuffer.CopyCountDelegate>("UnityEngine.ComputeBuffer::CopyCount");
			ComputeBuffer.GetNativeBufferPtrDelegateField = IL2CPP.ResolveICall<ComputeBuffer.GetNativeBufferPtrDelegate>("UnityEngine.ComputeBuffer::GetNativeBufferPtr");
		}

		// Token: 0x06001427 RID: 5159 RVA: 0x00051800 File Offset: 0x0004FA00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 498354, XrefRangeEnd = 498362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputeBuffer.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001428 RID: 5160 RVA: 0x00051834 File Offset: 0x0004FA34
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 498373, RefRangeEnd = 498380, XrefRangeStart = 498362, XrefRangeEnd = 498373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputeBuffer.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001429 RID: 5161 RVA: 0x00051868 File Offset: 0x0004FA68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 498380, XrefRangeEnd = 498387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputeBuffer.NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600142A RID: 5162 RVA: 0x000518A8 File Offset: 0x0004FAA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 498387, XrefRangeEnd = 498391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr InitBuffer(int count, int stride, ComputeBufferType type, ComputeBufferMode usage)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref count;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stride;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usage;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputeBuffer.NativeMethodInfoPtr_InitBuffer_Private_Static_IntPtr_Int32_Int32_ComputeBufferType_ComputeBufferMode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600142B RID: 5163 RVA: 0x00051910 File Offset: 0x0004FB10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 498391, XrefRangeEnd = 498395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DestroyBuffer(ComputeBuffer buf)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buf);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputeBuffer.NativeMethodInfoPtr_DestroyBuffer_Private_Static_Void_ComputeBuffer_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600142C RID: 5164 RVA: 0x00051948 File Offset: 0x0004FB48
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 498397, RefRangeEnd = 498401, XrefRangeStart = 498395, XrefRangeEnd = 498397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ComputeBuffer(int count, int stride)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref count;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stride;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputeBuffer.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600142D RID: 5165 RVA: 0x000519A0 File Offset: 0x0004FBA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 498401, XrefRangeEnd = 498403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ComputeBuffer(int count, int stride, ComputeBufferType type, ComputeBufferMode usage, int stackDepth)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ComputeBuffer>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref count;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stride;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usage;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stackDepth;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputeBuffer.NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_ComputeBufferType_ComputeBufferMode_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600142E RID: 5166 RVA: 0x00051A20 File Offset: 0x0004FC20
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 498373, RefRangeEnd = 498380, XrefRangeStart = 498373, XrefRangeEnd = 498380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Release()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputeBuffer.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000412 RID: 1042
		// (get) Token: 0x0600142F RID: 5167 RVA: 0x00051A54 File Offset: 0x0004FC54
		public unsafe int count
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 498403, XrefRangeEnd = 498407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputeBuffer.NativeMethodInfoPtr_get_count_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001430 RID: 5168 RVA: 0x0000B2A2 File Offset: 0x000094A2
		public ComputeBuffer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000411 RID: 1041
		// (get) Token: 0x06001431 RID: 5169 RVA: 0x00051A90 File Offset: 0x0004FC90
		// (set) Token: 0x06001432 RID: 5170 RVA: 0x0000B2AB File Offset: 0x000094AB
		public unsafe IntPtr m_Ptr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComputeBuffer.NativeFieldInfoPtr_m_Ptr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComputeBuffer.NativeFieldInfoPtr_m_Ptr)) = value;
			}
		}

		// Token: 0x06001433 RID: 5171 RVA: 0x00051AB8 File Offset: 0x0004FCB8
		public bool IsValid()
		{
			return this.m_Ptr != IntPtr.Zero;
		}

		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x06001434 RID: 5172 RVA: 0x0000B2C6 File Offset: 0x000094C6
		public int stride
		{
			get
			{
				return ComputeBuffer.get_strideDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x06001435 RID: 5173 RVA: 0x0000B2D8 File Offset: 0x000094D8
		public ComputeBufferMode usage
		{
			get
			{
				return ComputeBuffer.get_usageDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x06001436 RID: 5174 RVA: 0x00051ADC File Offset: 0x0004FCDC
		public void SetData(Array data)
		{
			bool flag = data == null;
			if (flag)
			{
				throw new ArgumentNullException("data");
			}
			bool flag2 = !Unity.Collections.LowLevel.Unsafe.UnsafeUtility.IsArrayBlittable(data);
			if (flag2)
			{
				throw new ArgumentException(String.Format("Array passed to ComputeBuffer.SetData(array) must be blittable.\n{0}", Unity.Collections.LowLevel.Unsafe.UnsafeUtility.GetReasonForArrayNonBlittable(data)));
			}
			this.InternalSetData(data, 0, 0, data.Length, Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf(data.GetType().GetElementType()));
		}

		// Token: 0x06001437 RID: 5175 RVA: 0x00051B44 File Offset: 0x0004FD44
		public void SetData<T>(List<T> data) where T : struct
		{
			bool flag = data == null;
			if (flag)
			{
				throw new ArgumentNullException("data");
			}
			bool flag2 = !Unity.Collections.LowLevel.Unsafe.UnsafeUtility.IsGenericListBlittable<T>();
			if (flag2)
			{
				throw new ArgumentException(String.Format("List<{0}> passed to ComputeBuffer.SetData(List<>) must be blittable.\n{1}", Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), Unity.Collections.LowLevel.Unsafe.UnsafeUtility.GetReasonForGenericListNonBlittable<T>()));
			}
			this.InternalSetData(NoAllocHelpers.ExtractArrayFromList(data), 0, 0, NoAllocHelpers.SafeLength<T>(data), Marshal.SizeOf(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>())));
		}

		// Token: 0x06001438 RID: 5176 RVA: 0x0000B2EA File Offset: 0x000094EA
		public void SetData<T>(Unity.Collections.NativeArray<T> data) where T : struct
		{
			this.InternalSetNativeData((IntPtr)data.GetUnsafeReadOnlyPtr<T>(), 0, 0, data.Length, Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>());
		}

		// Token: 0x06001439 RID: 5177 RVA: 0x00051BB8 File Offset: 0x0004FDB8
		public void SetData(Array data, int managedBufferStartIndex, int computeBufferStartIndex, int count)
		{
			bool flag = data == null;
			if (flag)
			{
				throw new ArgumentNullException("data");
			}
			bool flag2 = !Unity.Collections.LowLevel.Unsafe.UnsafeUtility.IsArrayBlittable(data);
			if (flag2)
			{
				throw new ArgumentException(String.Format("Array passed to ComputeBuffer.SetData(array) must be blittable.\n{0}", Unity.Collections.LowLevel.Unsafe.UnsafeUtility.GetReasonForArrayNonBlittable(data)));
			}
			bool flag3 = managedBufferStartIndex < 0 || computeBufferStartIndex < 0 || count < 0 || managedBufferStartIndex + count > data.Length;
			if (flag3)
			{
				throw new ArgumentOutOfRangeException(String.Format("Bad indices/count arguments (managedBufferStartIndex:{0} computeBufferStartIndex:{1} count:{2})", managedBufferStartIndex, computeBufferStartIndex, count));
			}
			this.InternalSetData(data, managedBufferStartIndex, computeBufferStartIndex, count, Marshal.SizeOf(data.GetType().GetElementType()));
		}

		// Token: 0x0600143A RID: 5178 RVA: 0x00051C5C File Offset: 0x0004FE5C
		public void SetData<T>(List<T> data, int managedBufferStartIndex, int computeBufferStartIndex, int count) where T : struct
		{
			bool flag = data == null;
			if (flag)
			{
				throw new ArgumentNullException("data");
			}
			bool flag2 = !Unity.Collections.LowLevel.Unsafe.UnsafeUtility.IsGenericListBlittable<T>();
			if (flag2)
			{
				throw new ArgumentException(String.Format("List<{0}> passed to ComputeBuffer.SetData(List<>) must be blittable.\n{1}", Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), Unity.Collections.LowLevel.Unsafe.UnsafeUtility.GetReasonForGenericListNonBlittable<T>()));
			}
			bool flag3 = managedBufferStartIndex < 0 || computeBufferStartIndex < 0 || count < 0 || managedBufferStartIndex + count > data.Count;
			if (flag3)
			{
				throw new ArgumentOutOfRangeException(String.Format("Bad indices/count arguments (managedBufferStartIndex:{0} computeBufferStartIndex:{1} count:{2})", managedBufferStartIndex, computeBufferStartIndex, count));
			}
			this.InternalSetData(NoAllocHelpers.ExtractArrayFromList(data), managedBufferStartIndex, computeBufferStartIndex, count, Marshal.SizeOf(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>())));
		}

		// Token: 0x0600143B RID: 5179 RVA: 0x00051D0C File Offset: 0x0004FF0C
		public void SetData<T>(Unity.Collections.NativeArray<T> data, int nativeBufferStartIndex, int computeBufferStartIndex, int count) where T : struct
		{
			bool flag = nativeBufferStartIndex < 0 || computeBufferStartIndex < 0 || count < 0 || nativeBufferStartIndex + count > data.Length;
			if (flag)
			{
				throw new ArgumentOutOfRangeException(String.Format("Bad indices/count arguments (nativeBufferStartIndex:{0} computeBufferStartIndex:{1} count:{2})", nativeBufferStartIndex, computeBufferStartIndex, count));
			}
			this.InternalSetNativeData((IntPtr)data.GetUnsafeReadOnlyPtr<T>(), nativeBufferStartIndex, computeBufferStartIndex, count, Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>());
		}

		// Token: 0x0600143C RID: 5180 RVA: 0x0000B30D File Offset: 0x0000950D
		public void InternalSetNativeData(IntPtr data, int nativeBufferStartIndex, int computeBufferStartIndex, int count, int elemSize)
		{
			ComputeBuffer.InternalSetNativeDataDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), data, nativeBufferStartIndex, computeBufferStartIndex, count, elemSize);
		}

		// Token: 0x0600143D RID: 5181 RVA: 0x0000B326 File Offset: 0x00009526
		public void InternalSetData(Array data, int managedBufferStartIndex, int computeBufferStartIndex, int count, int elemSize)
		{
			ComputeBuffer.InternalSetDataDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(data), managedBufferStartIndex, computeBufferStartIndex, count, elemSize);
		}

		// Token: 0x0600143E RID: 5182 RVA: 0x00051D7C File Offset: 0x0004FF7C
		public void GetData(Array data)
		{
			bool flag = data == null;
			if (flag)
			{
				throw new ArgumentNullException("data");
			}
			bool flag2 = !Unity.Collections.LowLevel.Unsafe.UnsafeUtility.IsArrayBlittable(data);
			if (flag2)
			{
				throw new ArgumentException(String.Format("Array passed to ComputeBuffer.GetData(array) must be blittable.\n{0}", Unity.Collections.LowLevel.Unsafe.UnsafeUtility.GetReasonForArrayNonBlittable(data)));
			}
			this.InternalGetData(data, 0, 0, data.Length, Marshal.SizeOf(data.GetType().GetElementType()));
		}

		// Token: 0x0600143F RID: 5183 RVA: 0x00051DE4 File Offset: 0x0004FFE4
		public void GetData(Array data, int managedBufferStartIndex, int computeBufferStartIndex, int count)
		{
			bool flag = data == null;
			if (flag)
			{
				throw new ArgumentNullException("data");
			}
			bool flag2 = !Unity.Collections.LowLevel.Unsafe.UnsafeUtility.IsArrayBlittable(data);
			if (flag2)
			{
				throw new ArgumentException(String.Format("Array passed to ComputeBuffer.GetData(array) must be blittable.\n{0}", Unity.Collections.LowLevel.Unsafe.UnsafeUtility.GetReasonForArrayNonBlittable(data)));
			}
			bool flag3 = managedBufferStartIndex < 0 || computeBufferStartIndex < 0 || count < 0 || managedBufferStartIndex + count > data.Length;
			if (flag3)
			{
				throw new ArgumentOutOfRangeException(String.Format("Bad indices/count argument (managedBufferStartIndex:{0} computeBufferStartIndex:{1} count:{2})", managedBufferStartIndex, computeBufferStartIndex, count));
			}
			this.InternalGetData(data, managedBufferStartIndex, computeBufferStartIndex, count, Marshal.SizeOf(data.GetType().GetElementType()));
		}

		// Token: 0x06001440 RID: 5184 RVA: 0x0000B344 File Offset: 0x00009544
		public void InternalGetData(Array data, int managedBufferStartIndex, int computeBufferStartIndex, int count, int elemSize)
		{
			ComputeBuffer.InternalGetDataDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(data), managedBufferStartIndex, computeBufferStartIndex, count, elemSize);
		}

		// Token: 0x06001441 RID: 5185 RVA: 0x0000B362 File Offset: 0x00009562
		public unsafe void* BeginBufferWrite([Optional] int offset, [Optional] int size)
		{
			return ComputeBuffer.BeginBufferWriteDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), offset, size);
		}

		// Token: 0x06001442 RID: 5186 RVA: 0x0000B376 File Offset: 0x00009576
		public Unity.Collections.NativeArray<T> BeginWrite<T>(int computeBufferStartIndex, int count) where T : struct
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001443 RID: 5187 RVA: 0x0000B383 File Offset: 0x00009583
		public void EndBufferWrite([Optional] int bytesWritten)
		{
			ComputeBuffer.EndBufferWriteDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), bytesWritten);
		}

		// Token: 0x06001444 RID: 5188 RVA: 0x00051E88 File Offset: 0x00050088
		public void EndWrite<T>(int countWritten) where T : struct
		{
			bool flag = countWritten < 0;
			if (flag)
			{
				throw new ArgumentOutOfRangeException(String.Format("Bad indices/count arguments (countWritten:{0})", countWritten));
			}
			int num = Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>();
			this.EndBufferWrite(countWritten * num);
		}

		// Token: 0x17000415 RID: 1045
		// (set) Token: 0x06001445 RID: 5189 RVA: 0x0000B396 File Offset: 0x00009596
		public string name
		{
			set
			{
				this.SetName(value);
			}
		}

		// Token: 0x06001446 RID: 5190 RVA: 0x0000B3A1 File Offset: 0x000095A1
		public void SetName(string name)
		{
			ComputeBuffer.SetNameDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(name));
		}

		// Token: 0x06001447 RID: 5191 RVA: 0x0000B3B9 File Offset: 0x000095B9
		public void SetCounterValue(uint counterValue)
		{
			ComputeBuffer.SetCounterValueDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), counterValue);
		}

		// Token: 0x06001448 RID: 5192 RVA: 0x0000B3CC File Offset: 0x000095CC
		public static void CopyCount(ComputeBuffer src, ComputeBuffer dst, int dstOffsetBytes)
		{
			ComputeBuffer.CopyCountDelegateField(IL2CPP.Il2CppObjectBaseToPtr(src), IL2CPP.Il2CppObjectBaseToPtr(dst), dstOffsetBytes);
		}

		// Token: 0x06001449 RID: 5193 RVA: 0x0000B3E5 File Offset: 0x000095E5
		public IntPtr GetNativeBufferPtr()
		{
			return ComputeBuffer.GetNativeBufferPtrDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x04000FF1 RID: 4081
		private static readonly IntPtr NativeFieldInfoPtr_m_Ptr;

		// Token: 0x04000FF2 RID: 4082
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04000FF3 RID: 4083
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000FF4 RID: 4084
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0;

		// Token: 0x04000FF5 RID: 4085
		private static readonly IntPtr NativeMethodInfoPtr_InitBuffer_Private_Static_IntPtr_Int32_Int32_ComputeBufferType_ComputeBufferMode_0;

		// Token: 0x04000FF6 RID: 4086
		private static readonly IntPtr NativeMethodInfoPtr_DestroyBuffer_Private_Static_Void_ComputeBuffer_0;

		// Token: 0x04000FF7 RID: 4087
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;

		// Token: 0x04000FF8 RID: 4088
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_ComputeBufferType_ComputeBufferMode_Int32_0;

		// Token: 0x04000FF9 RID: 4089
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Void_0;

		// Token: 0x04000FFA RID: 4090
		private static readonly IntPtr NativeMethodInfoPtr_get_count_Public_get_Int32_0;

		// Token: 0x04000FFB RID: 4091
		private static readonly ComputeBuffer.get_strideDelegate get_strideDelegateField;

		// Token: 0x04000FFC RID: 4092
		private static readonly ComputeBuffer.get_usageDelegate get_usageDelegateField;

		// Token: 0x04000FFD RID: 4093
		private static readonly ComputeBuffer.InternalSetNativeDataDelegate InternalSetNativeDataDelegateField;

		// Token: 0x04000FFE RID: 4094
		private static readonly ComputeBuffer.InternalSetDataDelegate InternalSetDataDelegateField;

		// Token: 0x04000FFF RID: 4095
		private static readonly ComputeBuffer.InternalGetDataDelegate InternalGetDataDelegateField;

		// Token: 0x04001000 RID: 4096
		private static readonly ComputeBuffer.BeginBufferWriteDelegate BeginBufferWriteDelegateField;

		// Token: 0x04001001 RID: 4097
		private static readonly ComputeBuffer.EndBufferWriteDelegate EndBufferWriteDelegateField;

		// Token: 0x04001002 RID: 4098
		private static readonly ComputeBuffer.SetNameDelegate SetNameDelegateField;

		// Token: 0x04001003 RID: 4099
		private static readonly ComputeBuffer.SetCounterValueDelegate SetCounterValueDelegateField;

		// Token: 0x04001004 RID: 4100
		private static readonly ComputeBuffer.CopyCountDelegate CopyCountDelegateField;

		// Token: 0x04001005 RID: 4101
		private static readonly ComputeBuffer.GetNativeBufferPtrDelegate GetNativeBufferPtrDelegateField;

		// Token: 0x020007CE RID: 1998
		// (Invoke) Token: 0x06002D9E RID: 11678
		private delegate int get_strideDelegate(IntPtr @this);

		// Token: 0x020007CF RID: 1999
		// (Invoke) Token: 0x06002DA0 RID: 11680
		private delegate ComputeBufferMode get_usageDelegate(IntPtr @this);

		// Token: 0x020007D0 RID: 2000
		// (Invoke) Token: 0x06002DA2 RID: 11682
		private delegate void InternalSetNativeDataDelegate(IntPtr @this, IntPtr data, int nativeBufferStartIndex, int computeBufferStartIndex, int count, int elemSize);

		// Token: 0x020007D1 RID: 2001
		// (Invoke) Token: 0x06002DA4 RID: 11684
		private delegate void InternalSetDataDelegate(IntPtr @this, IntPtr data, int managedBufferStartIndex, int computeBufferStartIndex, int count, int elemSize);

		// Token: 0x020007D2 RID: 2002
		// (Invoke) Token: 0x06002DA6 RID: 11686
		private delegate void InternalGetDataDelegate(IntPtr @this, IntPtr data, int managedBufferStartIndex, int computeBufferStartIndex, int count, int elemSize);

		// Token: 0x020007D3 RID: 2003
		// (Invoke) Token: 0x06002DA8 RID: 11688
		private delegate IntPtr BeginBufferWriteDelegate(IntPtr @this, int offset, int size);

		// Token: 0x020007D4 RID: 2004
		// (Invoke) Token: 0x06002DAA RID: 11690
		private delegate void EndBufferWriteDelegate(IntPtr @this, int bytesWritten);

		// Token: 0x020007D5 RID: 2005
		// (Invoke) Token: 0x06002DAC RID: 11692
		private delegate void SetNameDelegate(IntPtr @this, IntPtr name);

		// Token: 0x020007D6 RID: 2006
		// (Invoke) Token: 0x06002DAE RID: 11694
		private delegate void SetCounterValueDelegate(IntPtr @this, uint counterValue);

		// Token: 0x020007D7 RID: 2007
		// (Invoke) Token: 0x06002DB0 RID: 11696
		private delegate void CopyCountDelegate(IntPtr src, IntPtr dst, int dstOffsetBytes);

		// Token: 0x020007D8 RID: 2008
		// (Invoke) Token: 0x06002DB2 RID: 11698
		private delegate IntPtr GetNativeBufferPtrDelegate(IntPtr @this);
	}
}
