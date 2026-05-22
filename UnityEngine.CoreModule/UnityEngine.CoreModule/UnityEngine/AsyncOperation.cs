using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x020000C1 RID: 193
	public class AsyncOperation : YieldInstruction
	{
		// Token: 0x06001200 RID: 4608 RVA: 0x00049E58 File Offset: 0x00048058
		// Note: this type is marked as 'beforefieldinit'.
		static AsyncOperation()
		{
			Il2CppClassPointerStore<AsyncOperation>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "AsyncOperation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncOperation>.NativeClassPtr);
			AsyncOperation.NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncOperation>.NativeClassPtr, "m_Ptr");
			AsyncOperation.NativeFieldInfoPtr_m_completeCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncOperation>.NativeClassPtr, "m_completeCallback");
			AsyncOperation.NativeMethodInfoPtr_InternalDestroy_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperation>.NativeClassPtr, 100664803);
			AsyncOperation.NativeMethodInfoPtr_get_progress_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperation>.NativeClassPtr, 100664804);
			AsyncOperation.NativeMethodInfoPtr_set_allowSceneActivation_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperation>.NativeClassPtr, 100664805);
			AsyncOperation.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperation>.NativeClassPtr, 100664806);
			AsyncOperation.NativeMethodInfoPtr_InvokeCompletionEvent_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperation>.NativeClassPtr, 100664807);
			AsyncOperation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperation>.NativeClassPtr, 100664808);
			AsyncOperation.get_isDoneDelegateField = IL2CPP.ResolveICall<AsyncOperation.get_isDoneDelegate>("UnityEngine.AsyncOperation::get_isDone");
			AsyncOperation.get_priorityDelegateField = IL2CPP.ResolveICall<AsyncOperation.get_priorityDelegate>("UnityEngine.AsyncOperation::get_priority");
			AsyncOperation.set_priorityDelegateField = IL2CPP.ResolveICall<AsyncOperation.set_priorityDelegate>("UnityEngine.AsyncOperation::set_priority");
			AsyncOperation.get_allowSceneActivationDelegateField = IL2CPP.ResolveICall<AsyncOperation.get_allowSceneActivationDelegate>("UnityEngine.AsyncOperation::get_allowSceneActivation");
		}

		// Token: 0x06001201 RID: 4609 RVA: 0x00049F64 File Offset: 0x00048164
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 493977, XrefRangeEnd = 493981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InternalDestroy(IntPtr ptr)
		{
			checked
			{
				IntPtr* ptr2 = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperation.NativeMethodInfoPtr_InternalDestroy_Private_Static_Void_IntPtr_0, 0, (void**)ptr2, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x06001202 RID: 4610 RVA: 0x00049F98 File Offset: 0x00048198
		public unsafe float progress
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 493981, XrefRangeEnd = 493985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperation.NativeMethodInfoPtr_get_progress_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x0600120F RID: 4623 RVA: 0x0000A6E4 File Offset: 0x000088E4
		// (set) Token: 0x06001203 RID: 4611 RVA: 0x00049FD4 File Offset: 0x000481D4
		public unsafe bool allowSceneActivation
		{
			get
			{
				return AsyncOperation.get_allowSceneActivationDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 493989, RefRangeEnd = 493991, XrefRangeStart = 493985, XrefRangeEnd = 493989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperation.NativeMethodInfoPtr_set_allowSceneActivation_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001204 RID: 4612 RVA: 0x0004A014 File Offset: 0x00048214
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 493991, XrefRangeEnd = 493994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AsyncOperation.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001205 RID: 4613 RVA: 0x0004A050 File Offset: 0x00048250
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 493994, XrefRangeEnd = 493997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InvokeCompletionEvent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperation.NativeMethodInfoPtr_InvokeCompletionEvent_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001206 RID: 4614 RVA: 0x0004A084 File Offset: 0x00048284
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperation()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsyncOperation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001207 RID: 4615 RVA: 0x0000A66A File Offset: 0x0000886A
		public AsyncOperation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x06001208 RID: 4616 RVA: 0x0004A0C0 File Offset: 0x000482C0
		// (set) Token: 0x06001209 RID: 4617 RVA: 0x0000A673 File Offset: 0x00008873
		public unsafe IntPtr m_Ptr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncOperation.NativeFieldInfoPtr_m_Ptr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncOperation.NativeFieldInfoPtr_m_Ptr)) = value;
			}
		}

		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x0600120A RID: 4618 RVA: 0x0004A0E8 File Offset: 0x000482E8
		// (set) Token: 0x0600120B RID: 4619 RVA: 0x0000A68E File Offset: 0x0000888E
		public unsafe Action<AsyncOperation> m_completeCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncOperation.NativeFieldInfoPtr_m_completeCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<AsyncOperation>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncOperation.NativeFieldInfoPtr_m_completeCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x0600120C RID: 4620 RVA: 0x0000A6AD File Offset: 0x000088AD
		public bool isDone
		{
			get
			{
				return AsyncOperation.get_isDoneDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x0600120D RID: 4621 RVA: 0x0000A6BF File Offset: 0x000088BF
		// (set) Token: 0x0600120E RID: 4622 RVA: 0x0000A6D1 File Offset: 0x000088D1
		public int priority
		{
			get
			{
				return AsyncOperation.get_priorityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AsyncOperation.set_priorityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x06001210 RID: 4624 RVA: 0x0004A118 File Offset: 0x00048318
		public void add_completed(Action<AsyncOperation> value)
		{
			bool isDone = this.isDone;
			if (isDone)
			{
				value.Invoke(this);
			}
			else
			{
				this.m_completeCallback = Delegate.Combine(this.m_completeCallback, value).Cast<Action<AsyncOperation>>();
			}
		}

		// Token: 0x06001211 RID: 4625 RVA: 0x0000A6F6 File Offset: 0x000088F6
		public void remove_completed(Action<AsyncOperation> value)
		{
			this.m_completeCallback = Delegate.Remove(this.m_completeCallback, value).Cast<Action<AsyncOperation>>();
		}

		// Token: 0x04000E8E RID: 3726
		private static readonly IntPtr NativeFieldInfoPtr_m_Ptr;

		// Token: 0x04000E8F RID: 3727
		private static readonly IntPtr NativeFieldInfoPtr_m_completeCallback;

		// Token: 0x04000E90 RID: 3728
		private static readonly IntPtr NativeMethodInfoPtr_InternalDestroy_Private_Static_Void_IntPtr_0;

		// Token: 0x04000E91 RID: 3729
		private static readonly IntPtr NativeMethodInfoPtr_get_progress_Public_get_Single_0;

		// Token: 0x04000E92 RID: 3730
		private static readonly IntPtr NativeMethodInfoPtr_set_allowSceneActivation_Public_set_Void_Boolean_0;

		// Token: 0x04000E93 RID: 3731
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04000E94 RID: 3732
		private static readonly IntPtr NativeMethodInfoPtr_InvokeCompletionEvent_Internal_Void_0;

		// Token: 0x04000E95 RID: 3733
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000E96 RID: 3734
		private static readonly AsyncOperation.get_isDoneDelegate get_isDoneDelegateField;

		// Token: 0x04000E97 RID: 3735
		private static readonly AsyncOperation.get_priorityDelegate get_priorityDelegateField;

		// Token: 0x04000E98 RID: 3736
		private static readonly AsyncOperation.set_priorityDelegate set_priorityDelegateField;

		// Token: 0x04000E99 RID: 3737
		private static readonly AsyncOperation.get_allowSceneActivationDelegate get_allowSceneActivationDelegateField;

		// Token: 0x02000787 RID: 1927
		// (Invoke) Token: 0x06002D24 RID: 11556
		private delegate bool get_isDoneDelegate(IntPtr @this);

		// Token: 0x02000788 RID: 1928
		// (Invoke) Token: 0x06002D26 RID: 11558
		private delegate int get_priorityDelegate(IntPtr @this);

		// Token: 0x02000789 RID: 1929
		// (Invoke) Token: 0x06002D28 RID: 11560
		private delegate void set_priorityDelegate(IntPtr @this, int value);

		// Token: 0x0200078A RID: 1930
		// (Invoke) Token: 0x06002D2A RID: 11562
		private delegate bool get_allowSceneActivationDelegate(IntPtr @this);
	}
}
