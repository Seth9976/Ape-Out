using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000018 RID: 24
	public class ResonanceAudioMaterialMapperUpdater : MonoBehaviour
	{
		// Token: 0x06000371 RID: 881 RVA: 0x0003D9D4 File Offset: 0x0003BBD4
		// Note: this type is marked as 'beforefieldinit'.
		static ResonanceAudioMaterialMapperUpdater()
		{
			Il2CppClassPointerStore<ResonanceAudioMaterialMapperUpdater>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ResonanceAudioMaterialMapperUpdater");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResonanceAudioMaterialMapperUpdater>.NativeClassPtr);
			ResonanceAudioMaterialMapperUpdater.NativeFieldInfoPtr_RefreshMaterialMapper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudioMaterialMapperUpdater>.NativeClassPtr, "RefreshMaterialMapper");
			ResonanceAudioMaterialMapperUpdater.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceAudioMaterialMapperUpdater>.NativeClassPtr, 100663517);
			ResonanceAudioMaterialMapperUpdater.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceAudioMaterialMapperUpdater>.NativeClassPtr, 100663518);
		}

		// Token: 0x06000372 RID: 882 RVA: 0x0003DA40 File Offset: 0x0003BC40
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 33858, RefRangeEnd = 33864, XrefRangeStart = 33858, XrefRangeEnd = 33858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResonanceAudioMaterialMapperUpdater.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000373 RID: 883 RVA: 0x0003DA74 File Offset: 0x0003BC74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResonanceAudioMaterialMapperUpdater()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResonanceAudioMaterialMapperUpdater>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResonanceAudioMaterialMapperUpdater.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000374 RID: 884 RVA: 0x0000454B File Offset: 0x0000274B
		public ResonanceAudioMaterialMapperUpdater(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x06000375 RID: 885 RVA: 0x0003DAB0 File Offset: 0x0003BCB0
		// (set) Token: 0x06000376 RID: 886 RVA: 0x00004554 File Offset: 0x00002754
		public unsafe ResonanceAudioMaterialMapperUpdater.RefreshMaterialMapperDelegate RefreshMaterialMapper
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioMaterialMapperUpdater.NativeFieldInfoPtr_RefreshMaterialMapper);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResonanceAudioMaterialMapperUpdater.RefreshMaterialMapperDelegate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioMaterialMapperUpdater.NativeFieldInfoPtr_RefreshMaterialMapper), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040001FA RID: 506
		private static readonly IntPtr NativeFieldInfoPtr_RefreshMaterialMapper;

		// Token: 0x040001FB RID: 507
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040001FC RID: 508
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200029F RID: 671
		public sealed class RefreshMaterialMapperDelegate : MulticastDelegate
		{
			// Token: 0x06004A6B RID: 19051 RVA: 0x00113AFC File Offset: 0x00111CFC
			// Note: this type is marked as 'beforefieldinit'.
			static RefreshMaterialMapperDelegate()
			{
				Il2CppClassPointerStore<ResonanceAudioMaterialMapperUpdater.RefreshMaterialMapperDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ResonanceAudioMaterialMapperUpdater>.NativeClassPtr, "RefreshMaterialMapperDelegate");
				ResonanceAudioMaterialMapperUpdater.RefreshMaterialMapperDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceAudioMaterialMapperUpdater.RefreshMaterialMapperDelegate>.NativeClassPtr, 100663519);
				ResonanceAudioMaterialMapperUpdater.RefreshMaterialMapperDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceAudioMaterialMapperUpdater.RefreshMaterialMapperDelegate>.NativeClassPtr, 100663520);
				ResonanceAudioMaterialMapperUpdater.RefreshMaterialMapperDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceAudioMaterialMapperUpdater.RefreshMaterialMapperDelegate>.NativeClassPtr, 100663521);
				ResonanceAudioMaterialMapperUpdater.RefreshMaterialMapperDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceAudioMaterialMapperUpdater.RefreshMaterialMapperDelegate>.NativeClassPtr, 100663522);
			}

			// Token: 0x06004A6C RID: 19052 RVA: 0x00113B70 File Offset: 0x00111D70
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RefreshMaterialMapperDelegate(global::Il2CppSystem.Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResonanceAudioMaterialMapperUpdater.RefreshMaterialMapperDelegate>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResonanceAudioMaterialMapperUpdater.RefreshMaterialMapperDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004A6D RID: 19053 RVA: 0x00113BCC File Offset: 0x00111DCC
			[CallerCount(171)]
			[CachedScanResults(RefRangeStart = 1023, RefRangeEnd = 1194, XrefRangeStart = 1023, XrefRangeEnd = 1194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResonanceAudioMaterialMapperUpdater.RefreshMaterialMapperDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004A6E RID: 19054 RVA: 0x00113C00 File Offset: 0x00111E00
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(AsyncCallback callback, global::Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResonanceAudioMaterialMapperUpdater.RefreshMaterialMapperDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06004A6F RID: 19055 RVA: 0x00113C64 File Offset: 0x00111E64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResonanceAudioMaterialMapperUpdater.RefreshMaterialMapperDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004A70 RID: 19056 RVA: 0x0002BDA0 File Offset: 0x00029FA0
			public RefreshMaterialMapperDelegate(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06004A71 RID: 19057 RVA: 0x0002BDA9 File Offset: 0x00029FA9
			public static implicit operator ResonanceAudioMaterialMapperUpdater.RefreshMaterialMapperDelegate(Action A_0)
			{
				return DelegateSupport.ConvertDelegate<ResonanceAudioMaterialMapperUpdater.RefreshMaterialMapperDelegate>(A_0);
			}

			// Token: 0x06004A72 RID: 19058 RVA: 0x0002BDB1 File Offset: 0x00029FB1
			public static ResonanceAudioMaterialMapperUpdater.RefreshMaterialMapperDelegate operator +(ResonanceAudioMaterialMapperUpdater.RefreshMaterialMapperDelegate A_0, ResonanceAudioMaterialMapperUpdater.RefreshMaterialMapperDelegate A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<ResonanceAudioMaterialMapperUpdater.RefreshMaterialMapperDelegate>();
			}

			// Token: 0x06004A73 RID: 19059 RVA: 0x0002BDBF File Offset: 0x00029FBF
			public static ResonanceAudioMaterialMapperUpdater.RefreshMaterialMapperDelegate operator -(ResonanceAudioMaterialMapperUpdater.RefreshMaterialMapperDelegate A_0, ResonanceAudioMaterialMapperUpdater.RefreshMaterialMapperDelegate A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<ResonanceAudioMaterialMapperUpdater.RefreshMaterialMapperDelegate>();
				}
				return delegate2;
			}

			// Token: 0x0400306D RID: 12397
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x0400306E RID: 12398
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0;

			// Token: 0x0400306F RID: 12399
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0;

			// Token: 0x04003070 RID: 12400
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}
	}
}
