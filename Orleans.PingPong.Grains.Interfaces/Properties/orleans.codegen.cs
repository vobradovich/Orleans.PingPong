#if !EXCLUDE_CODEGEN
#pragma warning disable 162
#pragma warning disable 219
#pragma warning disable 414
#pragma warning disable 649
#pragma warning disable 693
#pragma warning disable 1591
#pragma warning disable 1998
[assembly: global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.1.0.0")]
[assembly: global::Orleans.CodeGeneration.OrleansCodeGenerationTargetAttribute("Orleans.PingPong.Grains.Interfaces, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")]
namespace Orleans.PingPong
{
    using global::Orleans.Async;
    using global::Orleans;

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.1.0.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (global::Orleans.PingPong.IClient))]
    internal class OrleansCodeGenClientReference : global::Orleans.Runtime.GrainReference, global::Orleans.PingPong.IClient
    {
        protected @OrleansCodeGenClientReference(global::Orleans.Runtime.GrainReference @other): base (@other)
        {
        }

        protected @OrleansCodeGenClientReference(global::System.Runtime.Serialization.SerializationInfo @info, global::System.Runtime.Serialization.StreamingContext @context): base (@info, @context)
        {
        }

        protected override global::System.Int32 InterfaceId
        {
            get
            {
                return 523268002;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return "global::Orleans.PingPong.IClient";
            }
        }

        public override global::System.Boolean @IsCompatible(global::System.Int32 @interfaceId)
        {
            return @interfaceId == 523268002;
        }

        protected override global::System.String @GetMethodName(global::System.Int32 @interfaceId, global::System.Int32 @methodId)
        {
            switch (@interfaceId)
            {
                case 523268002:
                    switch (@methodId)
                    {
                        case 1975541297:
                            return "Run";
                        case -2060440583:
                            return "Pong";
                        case 1682027821:
                            return "Initialize";
                        case -1238941369:
                            return "Subscribe";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + 523268002 + ",methodId=" + @methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
            }
        }

        public global::System.Threading.Tasks.Task @Run()
        {
            return base.@InvokeMethodAsync<global::System.Object>(1975541297, null);
        }

        public global::System.Threading.Tasks.Task @Pong(global::Orleans.PingPong.IDestination @from, global::Orleans.PingPong.Message @message)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-2060440583, new global::System.Object[]{@from is global::Orleans.Grain ? @from.@AsReference<global::Orleans.PingPong.IDestination>() : @from, @message});
        }

        public global::System.Threading.Tasks.Task @Initialize(global::Orleans.PingPong.IDestination @actor, global::System.Int64 @repeats)
        {
            return base.@InvokeMethodAsync<global::System.Object>(1682027821, new global::System.Object[]{@actor is global::Orleans.Grain ? @actor.@AsReference<global::Orleans.PingPong.IDestination>() : @actor, @repeats});
        }

        public global::System.Threading.Tasks.Task @Subscribe(global::Orleans.PingPong.IClientObserver @subscriber)
        {
            global::Orleans.CodeGeneration.GrainFactoryBase.@CheckGrainObserverParamInternal(@subscriber);
            return base.@InvokeMethodAsync<global::System.Object>(-1238941369, new global::System.Object[]{@subscriber is global::Orleans.Grain ? @subscriber.@AsReference<global::Orleans.PingPong.IClientObserver>() : @subscriber});
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.1.0.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute("global::Orleans.PingPong.IClient", 523268002, typeof (global::Orleans.PingPong.IClient)), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenClientMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
    {
        public global::System.Threading.Tasks.Task<global::System.Object> @Invoke(global::Orleans.Runtime.IAddressable @grain, global::System.Int32 @interfaceId, global::System.Int32 @methodId, global::System.Object[] @arguments)
        {
            try
            {
                if (@grain == null)
                    throw new global::System.ArgumentNullException("grain");
                switch (@interfaceId)
                {
                    case 523268002:
                        switch (@methodId)
                        {
                            case 1975541297:
                                return ((global::Orleans.PingPong.IClient)@grain).@Run().@Box();
                            case -2060440583:
                                return ((global::Orleans.PingPong.IClient)@grain).@Pong((global::Orleans.PingPong.IDestination)@arguments[0], (global::Orleans.PingPong.Message)@arguments[1]).@Box();
                            case 1682027821:
                                return ((global::Orleans.PingPong.IClient)@grain).@Initialize((global::Orleans.PingPong.IDestination)@arguments[0], (global::System.Int64)@arguments[1]).@Box();
                            case -1238941369:
                                return ((global::Orleans.PingPong.IClient)@grain).@Subscribe((global::Orleans.PingPong.IClientObserver)@arguments[0]).@Box();
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + 523268002 + ",methodId=" + @methodId);
                        }

                    default:
                        throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
                }
            }
            catch (global::System.Exception exception)
            {
                return global::Orleans.Async.TaskUtility.@Faulted(exception);
            }
        }

        public global::System.Int32 InterfaceId
        {
            get
            {
                return 523268002;
            }
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.1.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Orleans.PingPong.Message)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenOrleans_PingPong_MessageSerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            return original;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Orleans.PingPong.Message input = (global::Orleans.PingPong.Message)untypedInput;
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Orleans.PingPong.Message result = new global::Orleans.PingPong.Message();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            return (global::Orleans.PingPong.Message)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Orleans.PingPong.Message), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenOrleans_PingPong_MessageSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.1.0.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (global::Orleans.PingPong.IClientObserver))]
    internal class OrleansCodeGenClientObserverReference : global::Orleans.Runtime.GrainReference, global::Orleans.PingPong.IClientObserver
    {
        protected @OrleansCodeGenClientObserverReference(global::Orleans.Runtime.GrainReference @other): base (@other)
        {
        }

        protected @OrleansCodeGenClientObserverReference(global::System.Runtime.Serialization.SerializationInfo @info, global::System.Runtime.Serialization.StreamingContext @context): base (@info, @context)
        {
        }

        protected override global::System.Int32 InterfaceId
        {
            get
            {
                return 1126410990;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return "global::Orleans.PingPong.IClientObserver";
            }
        }

        public override global::System.Boolean @IsCompatible(global::System.Int32 @interfaceId)
        {
            return @interfaceId == 1126410990;
        }

        protected override global::System.String @GetMethodName(global::System.Int32 @interfaceId, global::System.Int32 @methodId)
        {
            switch (@interfaceId)
            {
                case 1126410990:
                    switch (@methodId)
                    {
                        case -1778340467:
                            return "Done";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + 1126410990 + ",methodId=" + @methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
            }
        }

        public void @Done(global::System.Int64 @pings, global::System.Int64 @pongs)
        {
            base.@InvokeOneWayMethod(-1778340467, new global::System.Object[]{@pings, @pongs});
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.1.0.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute("global::Orleans.PingPong.IClientObserver", 1126410990, typeof (global::Orleans.PingPong.IClientObserver)), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenClientObserverMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
    {
        public global::System.Threading.Tasks.Task<global::System.Object> @Invoke(global::Orleans.Runtime.IAddressable @grain, global::System.Int32 @interfaceId, global::System.Int32 @methodId, global::System.Object[] @arguments)
        {
            try
            {
                if (@grain == null)
                    throw new global::System.ArgumentNullException("grain");
                switch (@interfaceId)
                {
                    case 1126410990:
                        switch (@methodId)
                        {
                            case -1778340467:
                                ((global::Orleans.PingPong.IClientObserver)@grain).@Done((global::System.Int64)@arguments[0], (global::System.Int64)@arguments[1]);
                                return global::Orleans.Async.TaskUtility.@Completed();
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + 1126410990 + ",methodId=" + @methodId);
                        }

                    default:
                        throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
                }
            }
            catch (global::System.Exception exception)
            {
                return global::Orleans.Async.TaskUtility.@Faulted(exception);
            }
        }

        public global::System.Int32 InterfaceId
        {
            get
            {
                return 1126410990;
            }
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.1.0.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (global::Orleans.PingPong.IDestination))]
    internal class OrleansCodeGenDestinationReference : global::Orleans.Runtime.GrainReference, global::Orleans.PingPong.IDestination
    {
        protected @OrleansCodeGenDestinationReference(global::Orleans.Runtime.GrainReference @other): base (@other)
        {
        }

        protected @OrleansCodeGenDestinationReference(global::System.Runtime.Serialization.SerializationInfo @info, global::System.Runtime.Serialization.StreamingContext @context): base (@info, @context)
        {
        }

        protected override global::System.Int32 InterfaceId
        {
            get
            {
                return 1662910789;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return "global::Orleans.PingPong.IDestination";
            }
        }

        public override global::System.Boolean @IsCompatible(global::System.Int32 @interfaceId)
        {
            return @interfaceId == 1662910789;
        }

        protected override global::System.String @GetMethodName(global::System.Int32 @interfaceId, global::System.Int32 @methodId)
        {
            switch (@interfaceId)
            {
                case 1662910789:
                    switch (@methodId)
                    {
                        case 1491328371:
                            return "Ping";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + 1662910789 + ",methodId=" + @methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
            }
        }

        public global::System.Threading.Tasks.Task @Ping(global::Orleans.PingPong.IClient @from, global::Orleans.PingPong.Message @message)
        {
            return base.@InvokeMethodAsync<global::System.Object>(1491328371, new global::System.Object[]{@from is global::Orleans.Grain ? @from.@AsReference<global::Orleans.PingPong.IClient>() : @from, @message});
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.1.0.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute("global::Orleans.PingPong.IDestination", 1662910789, typeof (global::Orleans.PingPong.IDestination)), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenDestinationMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
    {
        public global::System.Threading.Tasks.Task<global::System.Object> @Invoke(global::Orleans.Runtime.IAddressable @grain, global::System.Int32 @interfaceId, global::System.Int32 @methodId, global::System.Object[] @arguments)
        {
            try
            {
                if (@grain == null)
                    throw new global::System.ArgumentNullException("grain");
                switch (@interfaceId)
                {
                    case 1662910789:
                        switch (@methodId)
                        {
                            case 1491328371:
                                return ((global::Orleans.PingPong.IDestination)@grain).@Ping((global::Orleans.PingPong.IClient)@arguments[0], (global::Orleans.PingPong.Message)@arguments[1]).@Box();
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + 1662910789 + ",methodId=" + @methodId);
                        }

                    default:
                        throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
                }
            }
            catch (global::System.Exception exception)
            {
                return global::Orleans.Async.TaskUtility.@Faulted(exception);
            }
        }

        public global::System.Int32 InterfaceId
        {
            get
            {
                return 1662910789;
            }
        }
    }
}
#pragma warning restore 162
#pragma warning restore 219
#pragma warning restore 414
#pragma warning restore 649
#pragma warning restore 693
#pragma warning restore 1591
#pragma warning restore 1998
#endif
