using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Yoga
{
	// Token: 0x02000003 RID: 3
	public sealed class MeasureFunction : MulticastDelegate
	{
		// Token: 0x0600000A RID: 10 RVA: 0x00002E54 File Offset: 0x00001054
		// Note: this type is marked as 'beforefieldinit'.
		static MeasureFunction()
		{
			Il2CppClassPointerStore<MeasureFunction>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsNativeModule.dll", "UnityEngine.Yoga", "MeasureFunction");
			MeasureFunction.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeasureFunction>.NativeClassPtr, 100663301);
			MeasureFunction.NativeMethodInfoPtr_Invoke_Public_Virtual_New_YogaSize_YogaNode_Single_YogaMeasureMode_Single_YogaMeasureMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeasureFunction>.NativeClassPtr, 100663302);
			MeasureFunction.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_YogaNode_Single_YogaMeasureMode_Single_YogaMeasureMode_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeasureFunction>.NativeClassPtr, 100663303);
			MeasureFunction.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_YogaSize_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeasureFunction>.NativeClassPtr, 100663304);
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002ECC File Offset: 0x000010CC
		[CallerCount(42)]
		[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MeasureFunction(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MeasureFunction>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeasureFunction.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002F28 File Offset: 0x00001128
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 533428, RefRangeEnd = 533430, XrefRangeStart = 533428, XrefRangeEnd = 533428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe YogaSize Invoke(YogaNode node, float width, YogaMeasureMode widthMode, float height, YogaMeasureMode heightMode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref widthMode;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref heightMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeasureFunction.NativeMethodInfoPtr_Invoke_Public_Virtual_New_YogaSize_YogaNode_Single_YogaMeasureMode_Single_YogaMeasureMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002FB0 File Offset: 0x000011B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 533430, XrefRangeEnd = 533441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(YogaNode node, float width, YogaMeasureMode widthMode, float height, YogaMeasureMode heightMode, AsyncCallback callback, Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref widthMode;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref heightMode;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeasureFunction.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_YogaNode_Single_YogaMeasureMode_Single_YogaMeasureMode_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00003060 File Offset: 0x00001260
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe YogaSize EndInvoke(IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeasureFunction.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_YogaSize_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002080 File Offset: 0x00000280
		public MeasureFunction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002089 File Offset: 0x00000289
		public static implicit operator MeasureFunction(Func<YogaNode, float, YogaMeasureMode, float, YogaMeasureMode, YogaSize> A_0)
		{
			return DelegateSupport.ConvertDelegate<MeasureFunction>(A_0);
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002091 File Offset: 0x00000291
		public static MeasureFunction operator +(MeasureFunction A_0, MeasureFunction A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<MeasureFunction>();
		}

		// Token: 0x06000012 RID: 18 RVA: 0x0000209F File Offset: 0x0000029F
		public static MeasureFunction operator -(MeasureFunction A_0, MeasureFunction A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<MeasureFunction>();
			}
			return delegate2;
		}

		// Token: 0x04000005 RID: 5
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04000006 RID: 6
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_YogaSize_YogaNode_Single_YogaMeasureMode_Single_YogaMeasureMode_0;

		// Token: 0x04000007 RID: 7
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_YogaNode_Single_YogaMeasureMode_Single_YogaMeasureMode_AsyncCallback_Object_0;

		// Token: 0x04000008 RID: 8
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_YogaSize_IAsyncResult_0;
	}
}
